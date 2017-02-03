Type.registerNamespace("DocumentManager.Designer.Scripts.Designer");

DocumentManager.Designer.Scripts.Designer = function (element) {
    //DocumentManager.Designer.Scripts.Designer.initializeBase(this, [element]);

    this._types = null;
    this._data = null;
    this._schema = null;
    this._options = null;
}

DocumentManager.Designer.Scripts.Designer.prototype =
{
    rtChange: false,
    mainViewField: null,
    mainPreviewField:  null,
    mainDesignerField: null,
    data: { },    
    schema: { },
    options: { },
    MODAL_TEMPLATE: ' \
        <div class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"> \
            <div class="modal-dialog"> \
                <div class="modal-content"> \
                    <div class="modal-header"> \
                        <button type="button" id="closebtn" class="close" data-dismiss="modal" aria-hidden="true">x</button>\
                        <h3 class="modal-title"></h3> \
                    </div> \
                    <div class="modal-body"></div> \
                </div> \
                <div class="modal-footer"></div> \
            </div> \
        </div> \
    ',
    initialize: function ()
    {
        /**
     * jQuery friendly method for binding a field to a DOM element.
     * @ignore
     */
        $.fn.alpaca = function () {
            var args = Alpaca.makeArray(arguments);

            // append this into the front of args
            var newArgs = [].concat(this, args);

            // hand back the field instance
            return Alpaca.apply(this, newArgs);
        };

        /**
         * @ignore
         * @param nocloning
         */
        $.fn.outerHTML = function (nocloning) {
            if (nocloning) {
                return $("<div></div>").append(this).html();
            } else {
                return $("<div></div>").append(this.clone()).html();
            }
        };

        /**
         * @ignore
         * @param to
         */
        $.fn.swapWith = function (to) {
            return this.each(function () {
                var copy_to = $(to).clone();
                var copy_from = $(this).clone();
                $(to).replaceWith(copy_from);
                $(this).replaceWith(copy_to);
            });
        };

        $.fn.attrProp = function (name, value) {
            return Alpaca.attrProp($(this), name, value);
        };

        //Alpaca.logLevel = Alpaca.DEBUG;

        DocumentManager.Designer.Scripts.Designer.callBaseMethod(this, 'initialize');        

        // Initializing Variables
        var _self = this;        
        
        $.each(_self.mappings, function (key, value) {
            Alpaca.registerDefaultSchemaFieldMapping(value, key);
        });

        // Alpaca.setDefaultLocale("es_ES");
        this.localize();

        
        // Background "thread" to detect changes and update the preview div
        var rtProcessing = false;
        
        this.rtFunction();

        var types = this.get_types();

        if (this.get_data())
            this.data = this.get_data();

        if (this.get_schema())
            this.schema = this.get_schema();

        if (this.get_options())
            this.options = this.get_options();
        
        for (var i = 0; i < types.length; i++) {
            var title = types[i].title;            
            var type = types[i].type;
            var description = types[i].description;
            var div = $("<div class='form-element draggable ui-widget-content' data-type='" + type + "'></div>");
            $(div).append("<div><span class='form-element-title'>" + title + "</span> (<span class='form-element-type'>" + type + "</span>)</div>");
            $(div).append("<div class='form-element-field-description'>" + description + "</div>");

            $("#types").append(div);
        }

        for (var type in Alpaca.fieldClassRegistry) {
            var instance = new Alpaca.fieldClassRegistry[type]();

            var schemaSchema = instance.getSchemaOfSchema();
            var schemaOptions = instance.getOptionsForSchema();
            var optionsSchema = instance.getSchemaOfOptions();
            var optionsOptions = instance.getOptionsForOptions();
            var title = instance.getTitle();
            var description = instance.getDescription();
            var type = instance.getType();
            var fieldType = instance.getFieldType();

            var div = $("<div class='form-element draggable ui-widget-content' data-type='" + type + "' data-field-type='" + fieldType + "'></div>");
            $(div).append("<div><span class='form-element-title'>" + title + "</span> (<span class='form-element-type'>" + fieldType + "</span>)</div>");
            $(div).append("<div class='form-element-field-description'>" + description + "</div>");

            var isCore = _self.isCoreField(fieldType);
            if (isCore) {
                $("#basic").append(div);
            }
            else {
                $("#advanced").append(div);
            }

            // Initializing all of the draggable form elements
            $(".form-element").draggable({
                "appendTo": "body",
                "helper": "clone",
                "zIndex": 300,
                "refreshPositions": true,
                "start": function (event, ui) {
                    $(".dropzone").addClass("dropzone-highlight");
                },
                "stop": function (event, ui) {
                    $(".dropzone").removeClass("dropzone-highlight");
                }
            });
        }

        $(".tab-item-view").click(function () {
            setTimeout(function () {
                _self.refreshView();
            }, 50);
        });

        $(".tab-item-designer").click(function () {
            setTimeout(function () {
                _self.refreshDesigner();
            }, 50);
        });        
        

        $(".tab-item-designer").click();
              
    },
    doRefresh: function (el, buildInteractionLayers, disableErrorHandling, cb) {
       
        _self = this;

        if (this.schema) {
            var config = {
                "schema": _self.schema
            };
            if (this.options) {
                config.options = _self.options;
            }
            if (this.data) {
                config.data = _self.data;
            }

            config.postRender = function (form) {

                if (buildInteractionLayers) {
                    var iCount = 0;
                    // Cover every control with an interaction layer
                    form.getEl().find(".alpaca-fieldset-item-container").each(function () {

                        var alpacaFieldId = $(this).attr("alpaca-id");

                        iCount++;
                        $(this).attr("icount", iCount);

                        var width = $(this).outerWidth();
                        var height = $(this).outerHeight();

                        // Cover div
                        var cover = $("<div></div>");
                        $(cover).addClass("cover");
                        $(cover).attr("alpaca-ref-id", alpacaFieldId);
                        $(cover).css({
                            "position": "relative",
                            "margin-top": "-" + height + "px",
                            "width": width,
                            "height": height,
                            "opacity": 0,
                            "background-color": "white",
                            "z-index": 900
                        });
                        $(cover).attr("icount-ref", iCount);
                        $(this).append(cover);
                        // Interaction div
                        var interaction = $("<div class='interaction'></div>");
                        var buttonGroup = $("<div class='btn-group pull-right'></div>");
                        var schemaButton = $('<button class="btn btn-default btn-xs button-schema" alpaca-ref-id="' + alpacaFieldId + '"><i class="glyphicon glyphicon-list"></i></button>');

                        buttonGroup.append(schemaButton);
                        var optionsButton = $('<button class="btn btn-default btn-xs button-options" alpaca-ref-id="' + alpacaFieldId + '"><i class="glyphicon glyphicon-wrench"></i></button>');

                        buttonGroup.append(optionsButton);
                        var removeButton = $('<button class="btn btn-danger btn-xs button-remove" alpaca-ref-id="' + alpacaFieldId + '"><i class="glyphicon glyphicon-remove whiten"></i></button>');

                        buttonGroup.append(removeButton);
                        interaction.append(buttonGroup);
                        interaction.append("<div style='clear:both'></div>");
                        $(interaction).addClass("interaction");
                        $(interaction).attr("alpaca-ref-id", alpacaFieldId);
                        $(interaction).css({
                            "position": "relative",
                            "margin-top": "-" + height + "px",
                            "width": width,
                            "height": height,
                            "opacity": 1,                            
                            "z-index": 901
                        });
                        $(interaction).attr("icount-ref", iCount);
                        $(this).append(interaction);
                        $(buttonGroup).css({
                            "margin-top": ($(interaction).height() / 2) - ($(buttonGroup).height() / 2),
                            "margin-right": "8px"
                        });
                            
                        $(schemaButton).off().click(function (e) {

                            e.preventDefault();
                            e.stopPropagation();

                            var alpacaId = $(this).attr("alpaca-ref-id");

                            _self.editSchema(alpacaId);
                        });

                        $(optionsButton).off().click(function (e) {

                            e.preventDefault();
                            e.stopPropagation();

                            var alpacaId = $(this).attr("alpaca-ref-id");                                
                            _self.editOptions(alpacaId);
                        });

                        $(removeButton).off().click(function (e) {

                            e.preventDefault();
                            e.stopPropagation();

                            var alpacaId = $(this).attr("alpaca-ref-id");
                            _self.removeField(alpacaId);
                        });

                        // When hover, highlight.
                        $(interaction).hover(function (e) {
                            var iCount = $(interaction).attr("icount-ref");
                            $(".cover[icount-ref='" + iCount + "']").addClass("ui-hover-state");
                        }, function (e) {
                            var iCount = $(interaction).attr("icount-ref");
                            $(".cover[icount-ref='" + iCount + "']").removeClass("ui-hover-state");
                        });
                    });                    

                    // Add dashed
                    form.getEl().find(".alpaca-fieldset-items-container").addClass("dashed");
                    form.getEl().find(".alpaca-fieldset-item-container").addClass("dashed");

                    // For every container, add a "first" drop zone element this covers empty containers as well as 0th index insertions.
                    form.getEl().find(".alpaca-fieldset-items-container").each(function () {
                        $(this).prepend("<div class='dropzone'></div>");
                    });

                    // After every element in a container, add something which allows inserts "after".
                    form.getEl().find(".alpaca-fieldset-item-container").each(function () {
                        $(this).after("<div class='dropzone'></div>");
                    });

                    form.getEl().find(".dropzone").droppable({
                        "tolerance": "touch",
                        "drop": function (event, ui) {
                            var draggable = $(ui.draggable);
                            if (draggable.hasClass("form-element")) {
                                var dataType = draggable.attr("data-type");
                                var fieldType = draggable.attr("data-field-type");
                                    
                                // Based on where the drop occurred, figure out the previous and next Alpaca fields surrounding the drop target.

                                // Previous
                                var previousField = null;
                                var previousFieldKey = null;
                                var previousItemContainer = $(event.target).prev();                                   
                                if (previousItemContainer) {
                                    var previousAlpacaId = $(previousItemContainer).attr("alpaca-id");
                                    previousField = Alpaca.fieldInstances[previousAlpacaId];

                                    previousFieldKey = $(previousItemContainer).attr("data-alpaca-item-container-item-key");
                                        
                                }

                                // Next
                                var nextField = null;
                                var nextFieldKey = null;
                                var nextItemContainer = $(event.target).next();
                                    
                                if (nextItemContainer) {
                                    var nextAlpacaId = $(nextItemContainer).attr("alpaca-id");
                                    nextField = Alpaca.fieldInstances[nextAlpacaId];

                                    nextFieldKey = $(nextItemContainer).attr("data-alpaca-item-container-item-key");
                                }

                                // Parent field
                                var parentFieldAlpacaId = $(event.target).parent().parent().attr("alpaca-field-id");
                                var parentField = Alpaca.fieldInstances[parentFieldAlpacaId];

                                // Now do the insertion                                
                                _self.insertField(_self.schema, _self.options, _self.data, dataType, fieldType, parentField, previousField, previousFieldKey, nextField, nextFieldKey);
                            }
                            else if (draggable.hasClass("interaction")) {
                                // TODO: dropping onto another interaction panel
                                _self.refresh();
                            }

                        },
                        "over": function (event, ui) {
                            $(event.target).addClass("dropzone-hover");
                        },
                        "out": function (event, ui) {
                            $(event.target).removeClass("dropzone-hover");
                        }
                    });

                    // Initializing any in-place draggables
                    form.getEl().find(".interaction").draggable({
                        "appendTo": "body",
                        "helper": function () {
                            var iCount = $(this).attr("icount-ref");
                            var clone = $(".alpaca-fieldset-item-container[icount='" + iCount + "']").clone();
                            return clone;
                        },
                        "cursorAt": {
                            "top": 100
                        },
                        "zIndex": 300,
                        "refreshPositions": true,
                        "start": function (event, ui) {
                            $(".dropzone").addClass("dropzone-highlight");
                        },
                        "stop": function (event, ui) {
                            $(".dropzone").removeClass("dropzone-highlight");
                        }
                    });
                }

                cb(null, form);
            };

            config.error = function (err) {
                Alpaca.defaultErrorCallback(err);

                cb(err);
            };

            if (disableErrorHandling) {
                Alpaca.defaultErrorCallback = function (error) {
                    console.log("Alpaca encountered an error while previewing form -> " + error.message);
                };
            }
            else {
                Alpaca.defaultErrorCallback = Alpaca.DEFAULT_ERROR_CALLBACK;
            }

            $(el).alpaca(config);
        }
    },
    editSchema: function (alpacaFieldId, callback) {
        _self = this;

        var field = Alpaca.fieldInstances[alpacaFieldId];

        var fieldSchema = field.getSchemaOfSchema();
        var fieldSchemaOptions = field.getOptionsForSchema();
        var fieldData = field.schema;

        delete fieldSchema.title;
        delete fieldSchema.description;
        if (fieldSchema.properties) {
            delete fieldSchema.properties.title;
            delete fieldSchema.properties.description;
            delete fieldSchema.properties.dependencies;
        }
        var fieldConfig = {
            schema: fieldSchema
        };
        if (fieldSchemaOptions) {
            fieldConfig.options = fieldSchemaOptions;
        }
        if (fieldData) {
            fieldConfig.data = fieldData;
        }
        fieldConfig.view = {
            "parent": "VIEW_DOTNETNUKE_EDIT",
            "displayReadonly": false
        };
        fieldConfig.postRender = function (control) {
            

            var modal = $(_self.MODAL_TEMPLATE.trim());
            modal.find(".modal-title").append(field.getTitle());
            modal.find(".modal-body").append(control.getEl());

            modal.find('.modal-footer').append("<button class='btn pull-right dnnSecondaryActionModal' data-dismiss='modal' aria-hidden='true'>Cancelar</button>");
            modal.find('.modal-footer').append("<button class='btn pull-right dnnPrimaryActionModal okay' data-dismiss='modal' aria-hidden='true'>Guardar</button>");
                


            $(modal).modal({
                "keyboard": true
            });

            $(modal).find(".okay").click(function () {                    
                field.schema = control.getValue();                    
                var top = _self.findTop(field);
                _self.regenerate(top);

                if (callback)
                {
                    callback();
                }
            });
                
            // Clean up the generated formatting
            control.getEl().find(".alpaca-controlfield-helper").remove();
            control.getEl().find(".alpaca-fieldset-helper").css({
                "padding-top": "0px",
                "padding-bottom": "0px"
            });
            control.getEl().find(".alpaca-fieldset-legend").css({
                "margin-bottom": "0px"
            });
            control.getEl().find("input").css({
                "margin-bottom": "0px"
            });
            control.getEl().find("label").css({
                "margin-bottom": "0px"
            });
            control.getEl().find(".alpaca-controlfield-container").css({
                "padding-top": "0px",
                "padding-bottom": "0px"
            });
            modal.find(".modal-body").css({
                "padding-top": "0px"
            });                
        };

        var x = $("<div><div class='fieldForm'></div></div>");
        $(x).find(".fieldForm").alpaca(fieldConfig);
    },
    editOptions: function (alpacaFieldId, callback) {
        var _self = this;

        var field = Alpaca.fieldInstances[alpacaFieldId];
        var fieldOptionsSchema = field.getSchemaOfOptions();
        var fieldOptionsOptions = field.getOptionsForOptions();
        var fieldOptionsData = field.options;

        delete fieldOptionsSchema.title;
        delete fieldOptionsSchema.description;
        if (fieldOptionsSchema.properties) {
            delete fieldOptionsSchema.properties.title;
            delete fieldOptionsSchema.properties.description;
            delete fieldOptionsSchema.properties.dependencies;
            delete fieldOptionsSchema.properties.readonly;
        }
        if (fieldOptionsOptions.fields) {
            delete fieldOptionsOptions.fields.title;
            delete fieldOptionsOptions.fields.description;
            delete fieldOptionsOptions.fields.dependencies;
            delete fieldOptionsOptions.fields.readonly;
        }

        var fieldConfig = {
            schema: fieldOptionsSchema
        };
        if (fieldOptionsOptions) {
            fieldConfig.options = fieldOptionsOptions;
        }
        if (fieldOptionsData) {
            fieldConfig.data = fieldOptionsData;
        }
        fieldConfig.view = {
            "parent": "VIEW_DOTNETNUKE_EDIT",
            "displayReadonly": false
        };

        fieldConfig.postRender = function (control) {
            var modal = $(_self.MODAL_TEMPLATE.trim());
            modal.find(".modal-title").append(field.getTitle());
            modal.find(".modal-body").append(control.getEl());

            modal.find('.modal-footer').append("<button class='btn pull-right dnnSecondaryActionModal' data-dismiss='modal' aria-hidden='true'>Cancelar</button>");
            modal.find('.modal-footer').append("<button class='btn pull-right okay dnnPrimaryActionModal' data-dismiss='modal' aria-hidden='true'>Guardar</button>");

            $(modal).modal({
                "keyboard": true
            });

            $(modal).find(".okay").click(function () {
                field.options = control.getValue();
                var top = _self.findTop(field);
                _self.regenerate(top);
                if (callback) {
                    callback();
                }
            });
        };

        var x = $("<div><div class='fieldForm'></div></div>");
        $(x).find(".fieldForm").alpaca(fieldConfig);
    },
    dispose: function ()
    {
        DocumentManager.Designer.Scripts.Designer.dispose(this, 'dispose');
    },
    refreshView: function (callback) {
        var _self = this;

        if (_self.mainViewField) {
            _self.mainViewField.getEl().replaceWith("<div id='viewDiv'></div>");
            _self.mainViewField.destroy();
            _self.mainViewField = null;
        }

        _self.doRefresh($("#viewDiv"), false, false, function (err, form) {

            if (!err) {
                _self.mainViewField = form;
            }

            if (callback) {
                callback();
            }

        });
    },
    refreshPreview: function (callback) {
        var _self = this;

        if (mainPreviewField) {
            mainPreviewField.getEl().replaceWith("<div id='previewDiv'></div>");
            mainPreviewField.destroy();
            mainPreviewField = null;
        }

        _self.doRefresh($("#previewDiv"), false, false, function (err, form) {

            if (!err) {
                mainPreviewField = form;
            }

            if (callback) {
                callback();
            }

        });
    },
    refreshDesigner: function (callback) {
                
        var _self = this;
        
        $(".dropzone").remove();
        $(".interaction").remove();
        $(".cover").remove();

        if (_self.mainDesignerField) {
            _self.mainDesignerField.getEl().replaceWith("<div id='designerDiv'></div>");
            _self.mainDesignerField.destroy();
            _self.mainDesignerField = null;
        }
        
        this.doRefresh($("#designerDiv"), true, false, function (err, form) {

            if (!err) {
                _self.mainDesignerField = form;
            }
            
            if (callback) {
                callback();
            }

        });

        $("#" + _self.get_schemaHF()).val(JSON.stringify(_self.schema));
        $("#" + _self.get_optionHF()).val(JSON.stringify(_self.options));
    },
    refreshCode: function (callback) {

        var _self = this;

        var json = {
            "schema": schema
        };
        if (options) {
            json.options = _self.options;
        }
        if (data) {
            json.data = _self.data;
        }
        var code = "$('#div').alpaca(" + JSON.stringify(json, null, "    ") + ");";

        editor4.setValue(code);
        editor4.clearSelection();
        editor4.gotoLine(0, 0);

        if (callback) {
            callback();
        }
    },
    refresh: function (callback) {
        var current = $("UL.nav.nav-tabs LI.active A.tab-item");
        $(current).click();
    },
    rtFunction: function () {

        if (this.rtChange && !rtProcessing) {
            rtProcessing = true;
            if (mainPreviewField) {
                mainPreviewField.getEl().replaceWith("<div id='previewDiv'></div>");
                mainPreviewField.destroy();
                mainPreviewField = null;
            }
            doRefresh($("#previewDiv"), false, true, function (err, form) {

                if (!err) {
                    mainPreviewField = form;
                }

                this.rtChange = false;
                rtProcessing = false;
            });
        }

        setTimeout(this.rtFunction, 1000);

    },
    insertField: function (schema, options, data, dataType, fieldType, parentField, previousField, previousFieldKey, nextField, nextFieldKey) {

        var _self = this;

        var itemSchema = {
            "type": dataType
        };
        var itemOptions = {};
        if (fieldType) {
            itemOptions.type = fieldType;
        }
        itemOptions.label = "New ";
        if (fieldType) {
            itemOptions.label += fieldType;
        }
        else if (dataType) {
            itemOptions.label += dataType;
        }
        var itemData = null;

        var itemKey = null;
        if (parentField.getType() === "array") {
            itemKey = 0;
            if (previousFieldKey) {
                itemKey = previousFieldKey + 1;
            }
        }
        else if (parentField.getType() === "object") {
            itemKey = "new" + new Date().getTime();
        }

        var insertAfterId = null;
        if (previousField) {
            insertAfterId = previousField.id;
        }

        parentField.addItem(itemKey, itemSchema, itemOptions, itemData, insertAfterId, false);
        
        var top = _self.findTop(parentField);
        
        _self.regenerate(top);
    },
    assembleSchema: function (field, schema) {
        var _self = this;

        for (var k in field.schema) {
            if (field.schema.hasOwnProperty(k) && typeof (field.schema[k]) != "function") {
                schema[k] = field.schema[k];
            }
        }
        // A few that we handle by hand        
        schema.type = _self.mappings[field.type];
        // Reset properties, we handle that one at a time
        delete schema.properties;
        if (field.childrenByPropertyId) {
            schema.properties = {};
            for (var propertyId in field.childrenByPropertyId) {
                var childField = field.childrenByPropertyId[propertyId];
                schema.properties[propertyId] = {};
                _self.assembleSchema(childField, schema.properties[propertyId]);
            }
        }
    },
    assembleOptions: function (field, options) {
        var _self = this;
        // Copy any properties from this field's options into our options object
        for (var k in field.options) {
            if (field.options.hasOwnProperty(k) && typeof (field.options[k]) != "function") {
                options[k] = field.options[k];
            }
        }
        // A few that we handle by hand

        try { options.type = field.getFieldType(); } catch (err) { }

        // Reset fields, we handle that one at a time
        delete options.fields;
        if (field.childrenByPropertyId) {
            options.fields = {};
            for (var propertyId in field.childrenByPropertyId) {
                var childField = field.childrenByPropertyId[propertyId];
                options.fields[propertyId] = {};
                _self.assembleOptions(childField, options.fields[propertyId]);
            }
        }
    },
    findTop: function (field) {

        // Now get the top control
        var top = field;
        while (top.parent) {
            top = top.parent;
        }

        return top;
    },
    regenerate: function (top) {
        var _self = this;
        // Walk the control tree and re-assemble the schema, options + data

        var _schema = {};
        _self.assembleSchema(top, _self.schema);
        var _options = {};
        _self.assembleOptions(top, _self.options);

        // Data is easy
        var _data = top.getValue();
        if (!_data) {
            _data = {};
        }

        setTimeout(function () {
            _self.refresh();
        }, 100);

    },
    removeField: function (alpacaId)
    {
        var _self = this;

        var field = Alpaca.fieldInstances[alpacaId];

        var parentField = field.parent;
        parentField.removeItem(alpacaId);

        var top = _self.findTop(field);
        _self.regenerate(top);
    },
    mappings: {
        textarea: "MultilineText",
        date: "DatePicker",
        text: "ShortText",
        number: "Number",
        checkbox: "BooleanField",
        select: "RadComboBox",
        file: "UploadFile",
        datetime: "DateTimePicker",
        hidden: "Hidden",        
    },
    isCoreField : function(type)
    {
        var cores = ["any", "array", "checkbox", "file", "hidden", "number", "object", "radio", "select", "text", "textarea"];

        var isCore = false;
        for (var i = 0; i < cores.length; i++)
        {
            if (cores[i] == type)
            {
                isCore = true;
            }
        }

        return isCore;
    },
    get_types: function () {
        return JSON.parse(this._types);
    },
    get_data: function () {
        if (!this._data)
            return null;

        return JSON.parse(this._data);
    },
    get_schema: function () {
        if (!this._schema)
            return null;

        return JSON.parse(this._schema);
    },
    get_options: function () {
        if (!this._options)
            return null;

        return JSON.parse(this._options);
    },
    get_optionHF: function () {
        return this._optionHF;
    },
    get_schemaHF: function () {
        return this._schemaHF;
    },
    localize: function () {
        /*Default Localization*/
        Globalize.addCultureInfo("default", {
            messages: {
                "Alpaca.Field.Title.Title": "title",
                "Alpaca.Field.Title.Description": "Short description of the property.",
                "Alpaca.Field.Readonly.Title": "Readonly",
                "Alpaca.Field.Readonly.Description": "Property will be readonly if true.",
                "Alpaca.Field.Required.Title": "Required",
                "Alpaca.Field.Required.Description": "Property value must be set if true.",
                "Alpaca.Field.Default.Title": "Default",
                "Alpaca.Field.Default.Description": "Default value of the property.",
                "Alpaca.Field.Type.Title": "Type",
                "Alpaca.Field.Type.Description": "Data type of the property.",
                "Alpaca.Field.Format.Title": "Format",
                "Alpaca.Field.Format.Description": "Data format of the property.",
                "Alpaca.Field.Disallow.Title": "Disallowed Values",
                "Alpaca.Field.Disallow.Description": "List of disallowed values for the property.",
                "Alpaca.Field.Dependencies.Title": "Dependencies",
                "Alpaca.Field.Dependencies.Description": "List of property dependencies.",
                "Alpaca.Field.Id.Title": "Field Type",
                "Alpaca.Field.Id.Description": "Unique field id. Auto-generated if not provided.",
                "Alpaca.Field.SchemaOfOptions.Type.Title": "Field Type",
                "Alpaca.Field.SchemaOfOptions.Type.Description": "Field Type",
                "Alpaca.Field.Validate.Title": "Validation",
                "Alpaca.Field.Validate.Description": "Field validation is required if true.",
                "Alpaca.Field.showMessages.Title": "Show Messages",
                "Alpaca.Field.showMessages.Description": "Display validation messages if true.",
                "Alpaca.Field.Disabled.Title": "Disabled",
                "Alpaca.Field.Disabled.Description": "Field will be disabled if true.",
                "Alpaca.Field.SchemaOfOptions.Readonly.Description": "Field will be readonly if true.",
                "Alpaca.Field.Hidden.Title": "Hidden",
                "Alpaca.Field.Hidden.Description": "Field will be hidden if true.",
                "Alpaca.Field.Label.Title": "Label",
                "Alpaca.Field.Label.Description": "Field Label",
                "Alpaca.Field.Helper.Title": "Helper",
                "Alpaca.Field.Helper.Description": "Field help message.",
                "Alpaca.Field.FieldClass.Title": "Css Class",
                "Alpaca.Field.FieldClass.Description": "Specifies one or more CSS classes that should be applied to the dom element for this field once it is rendered.  Supports a single value, comma-delimited values, space-delimited values or values passed in as an array.",
                "Alpaca.Field.HideInitValidationError.Title": "Hide Initial Validation Errors",
                "Alpaca.Field.HideInitValidationError.Description": "Hide initial validation errors if true.",
                "Alpaca.Field.Focus.Title": "Focus",
                "Alpaca.Field.Focus.Description": "If true, the initial focus for the form will be set to the first child element (usually the first field in the form).  If a field name or path is provided, then the specified child field will receive focus.  For example, you might set focus to 'name' (selecting the 'name' field) or you might set it to 'client/name' which picks the 'name' field on the 'client' object.",
                "Alpaca.Field.OptionLabels.Title": "Enumerated Value Labels",
                "Alpaca.Field.OptionLabels.Description": "An array of string labels for items in the enum array",
                "Alpaca.ControlField.Enum.Title": "Enumerated Values",
                "Alpaca.ControlField.Enum.Description": "List of specific values for this property.",
                "Alpaca.ControlField.Name.Title": "Field Name",
                "Alpaca.ControlField.Name.Description": "Field Name",
                "Alpaca.Fields.TextField.MinLength.Title": "Minimal Length",
                "Alpaca.Fields.TextField.MinLength.Description": "Minimal length of the property value.",
                "Alpaca.Fields.TextField.MaxLength.Title": "Maximum Length",
                "Alpaca.Fields.TextField.MaxLength.Description": "Maximum length of the property value.",
                "Alpaca.Fields.TextField.Pattern.Title": "Pattern",
                "Alpaca.Fields.TextField.Pattern.Description": "Regular expression for the property value.",
                "Alpaca.Fields.TextField.Size.Title": "Field size",
                "Alpaca.Fields.TextField.Size.Description": "Field size",
                "Alpaca.Fields.TextField.MaskString.Title": "Mask Expression",
                "Alpaca.Fields.TextField.MaskString.Description": "Expression for the field mask. Field masking will be enabled if not empty.",
                "Alpaca.Fields.TextField.Placeholder.Title": "Field Placehorlder",
                "Alpaca.Fields.TextField.Placeholder.Description": "Field Placehorlder",
                "Alpaca.Fields.TextField.Typeahead.Title": "Type Ahead",
                "Alpaca.Fields.TextField.Typeahead.Description": "Provides configuration for the $.typeahead plugin if it is available.",
                "Alpaca.Fields.TextField.AllowOptionalEmpty.Title": "Allow Optional Empty",
                "Alpaca.Fields.TextField.AllowOptionalEmpty.Description": "Allows this non-required field to validate when the value is empty",
                "Alpaca.Fields.NumberField.MultipleOf.Title": "Multiple Of",
                "Alpaca.Fields.NumberField.MultipleOf.Description": "Property value must be a multiple of the multipleOf schema property such that division by this value yields an interger (mod zero).",
                "Alpaca.Fields.NumberField.Minimum.Title": "Minimum",
                "Alpaca.Fields.NumberField.Minimum.Description": "Minimum value of the property.",
                "Alpaca.Fields.NumberField.Maximum.Title": "Maximum",
                "Alpaca.Fields.NumberField.Maximum.Description": "Maximum value of the property.",
                "Alpaca.Fields.NumberField.ExclusiveMinimum.Title": "Exclusive Minimum",
                "Alpaca.Fields.NumberField.ExclusiveMinimum.Description": "Property value can not equal the number defined by the minimum schema property.",
                "Alpaca.Fields.NumberField.ExclusiveMaximum.Title": "Exclusive Maximum",
                "Alpaca.Fields.NumberField.ExclusiveMaximum.Description": "Property value can not equal the number defined by the maximum schema property.",
                "Alpaca.Fields.ArrayField.Items.Title": "Array Items",
                "Alpaca.Fields.ArrayField.Items.SchemaOfSchema.Description": "Schema for array items.",
                "Alpaca.Fields.ArrayField.Items.SchemaOfOptions.Description": "Schema for array items.",
                "Alpaca.Fields.ArrayField.Items.MinItems.Title": "Minimum Items",
                "Alpaca.Fields.ArrayField.Items.MinItems.Description": "Minimum number of items.",
                "Alpaca.Fields.ArrayField.Items.MaxItems.Title": "Maximum Items",
                "Alpaca.Fields.ArrayField.Items.MaxItems.Description": "Maximum number of items.",
                "Alpaca.Fields.ArrayField.Items.UniqueItems.Title": "Items Unique",
                "Alpaca.Fields.ArrayField.Items.UniqueItems.Description": "Item values should be unique if true.",
                "Alpaca.Fields.ArrayField.ToolbarSticky.Title": "Sticky Toolbar",
                "Alpaca.Fields.ArrayField.ToolbarSticky.Description": "Array item toolbar will be aways on if true.",
                "Alpaca.Fields.ArrayField.ExtraToolbarButtons.Title": "Extra Toolbar buttons",
                "Alpaca.Fields.ArrayField.ExtraToolbarButtons.Description": "Buttons to be added next to add/remove/up/down, see examples",
                "Alpaca.Fields.ArrayField.MoveUpItemLabel.Title": "Move Up Item Label",
                "Alpaca.Fields.ArrayField.MoveUpItemLabel.Description": "The label to use for the toolbar's 'move up' button.",
                "Alpaca.Fields.ArrayField.MoveUpItemLabel.Default": "Move Up",
                "Alpaca.Fields.ArrayField.MoveDownItemLabel.Title": "Move Down Item Label",
                "Alpaca.Fields.ArrayField.MoveDownItemLabel.Description": "The label to use for the toolbar's 'move down' button.",
                "Alpaca.Fields.ArrayField.MoveDownItemLabel.Default": "Move Down",
                "Alpaca.Fields.ArrayField.RemoveItemLabel.Title": "Remove Item Label",
                "Alpaca.Fields.ArrayField.RemoveItemLabel.Description": "The label to use for the toolbar's 'remove item' button.",
                "Alpaca.Fields.ArrayField.MoveDownItemLabel.Default": "Remove",
                "Alpaca.Fields.ArrayField.AddItemLabel.Title": "Add Item Label",
                "Alpaca.Fields.ArrayField.AddItemLabel.Description": "The label to use for the toolbar's 'add item' button.",
                "Alpaca.Fields.ArrayField.AddItemLabel.Default": "Add",
                "Alpaca.Fields.ArrayField.ShowMoveDownItemButton.Title": "Show Move Down Item Button",
                "Alpaca.Fields.ArrayField.ShowMoveDownItemButton.Description": "Whether to show to the 'Move Down' button on the toolbar.",
                "Alpaca.Fields.ArrayField.ShowMoveUpItemButton.Title": "Show Move Up Item Button",
                "Alpaca.Fields.ArrayField.ShowMoveUpItemButton.Description": "Whether to show the 'Move Up' button on the toolbar.",
                "Alpaca.Fields.CheckBoxField.RightLabel.Title": "Option Label",
                "Alpaca.Fields.CheckBoxField.RightLabel.Description": "Optional right-hand side label for single checkbox field.",
                "Alpaca.Fields.CheckBoxField.Multiple.Title": "Multiple",
                "Alpaca.Fields.CheckBoxField.Multiple.Description": "Whether to render multiple checkboxes for multi-valued type (such as an array or a comma-delimited string)",
                "Alpaca.Fields.FileField.SelectionHandler.Title": "Selection Handler",
                "Alpaca.Fields.FileField.SelectionHandler.Description": "Function that should be called when files are selected.  Requires HTML5.",
                "Alpaca.Fields.ListField.Enum.Title": "Enumeration",
                "Alpaca.Fields.ListField.Enum.Description": "List of field value options",
                "Alpaca.Fields.ListField.OptionLabels.Title": "Option Labels",
                "Alpaca.Fields.ListField.OptionLabels.Description": "Labels for options. It can either be a map object or an array field that maps labels to items defined by enum schema property one by one.",
                "Alpaca.Fields.ListField.DataSource.Title": "Option Datasource",
                "Alpaca.Fields.ListField.DataSource.Description": "Datasource for generating list of options.  This can be a string or a function.  If a string, it is considered to be a URI to a service that produces a object containing key/value pairs or an array of elements of structure {'text': '', 'value': ''}.  This can also be a function that is called to produce the same list.",
                "Alpaca.Fields.ListField.RemoveDefaultNone.Title": "Remove Default None",
                "Alpaca.Fields.ListField.RemoveDefaultNone.Description": "If true, the default 'None' option will not be shown.",
                "Alpaca.Fields.ObjectField.Properties.Title": "Properties",
                "Alpaca.Fields.ObjectField.Properties.Description": "List of child properties.",
                "Alpaca.Fields.ObjectField.MaxProperties.Title": "Maximum Number Properties",
                "Alpaca.Fields.ObjectField.MaxProperties.Description": "The maximum number of properties that this object is allowed to have",
                "Alpaca.Fields.ObjectField.MinProperties.Title": "Minimun Number Properties",
                "Alpaca.Fields.ObjectField.MinProperties.Description": "The minimum number of properties that this object is required to have",
                "Alpaca.Fields.ObjectField.Fields.Title": "Fields Options",
                "Alpaca.Fields.ObjectField.Fields.Description": "List of options for child fields.",
                "Alpaca.ContainerField.LazyLoading.Title": "Lazy Loading",
                "Alpaca.ContainerField.LazyLoading.Description": "Child fields will only be rendered when the fieldset is expanded if this option is set true.",
                "Alpaca.ContainerField.LazyLoading.RightLabel": "Lazy loading child fields ?",
                "Alpaca.ContainerField.LazyLoading.Helper": "Lazy loading will be enabled if checked.",
                "Alpaca.ContainerField.Collapsible.Title": "Collapsible",
                "Alpaca.ContainerField.Collapsible.Description": "Field set is collapsible if true.",
                "Alpaca.ContainerField.Collapsible.RightLabel": "Field set collapsible ?",
                "Alpaca.ContainerField.Collapsible.Helper": "Field set is collapsible if checked.",
                "Alpaca.ContainerField.Collapsed.Title": "Collapsed",
                "Alpaca.ContainerField.Collapsed.Description": "Field set is initially collapsed if true.",
                "Alpaca.ContainerField.Collapsed.RightLabel": "Field set initially collapsed ?",
                "Alpaca.ContainerField.LegendStyle.Title": "Legend Style",
                "Alpaca.ContainerField.LegendStyle.Description": "Field set legend style.",
                "Alpaca.ContainerField.LegendStyle.Title": "Legend Style",
                "Alpaca.Fields.RadioField.Name.Title": "Field name",
                "Alpaca.Fields.RadioField.Name.Description": "Field name",
                "Alpaca.Fields.RadioField.EmptySelectFirst.Title": "Empty Select First",
                "Alpaca.Fields.RadioField.EmptySelectFirst.Description": "If the data is empty, then automatically select the first item in the list.",
                "Alpaca.Fields.RadioField.EmptySelectFirst.Title": "Empty Select First",
            }
        });

        /*Prototyping the Fields in order to Localize them*/

        Alpaca.Field.prototype.getSchemaOfSchema = function () {
            var schemaOfSchema = {
                "title": this.getTitle(),
                "description": this.getDescription(),
                "type": "object",
                "properties": {
                    "title": {
                        "title": Globalize.localize("Alpaca.Field.Title.Title"),
                        "description": Globalize.localize("Alpaca.Field.Title.Description"),
                        "type": "string"
                    },
                    "description": {
                        "title": "Description",
                        "description": "Detailed description of the property.",
                        "type": "string"
                    },
                    "readonly": {
                        "title": Globalize.localize("Alpaca.Field.Readonly.Title"),
                        "description": Globalize.localize("Alpaca.Field.Readonly.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "required": {
                        "title": Globalize.localize("Alpaca.Field.Required.Title"),
                        "description": Globalize.localize("Alpaca.Field.Required.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "default": {
                        "title": Globalize.localize("Alpaca.Field.Default.Title"),
                        "description": Globalize.localize("Alpaca.Field.Default.Description"),
                        "type": "any"
                    },
                    "type": {
                        "title": Globalize.localize("Alpaca.Field.Type.Title"),
                        "description": Globalize.localize("Alpaca.Field.Type.Description"),
                        "type": "string",
                        "readonly": true
                    },
                    "format": {
                        "title": Globalize.localize("Alpaca.Field.Format.Title"),
                        "description": Globalize.localize("Alpaca.Field.Format.Description"),
                        "type": "string"
                    },
                    "disallow": {
                        "title": Globalize.localize("Alpaca.Field.Disallow.Title"),
                        "description": Globalize.localize("Alpaca.Field.Disallow.Description"),
                        "type": "array"
                    },
                    "dependencies": {
                        "title": Globalize.localize("Alpaca.Field.Dependencies.Title"),
                        "description": Globalize.localize("Alpaca.Field.Dependencies.Description"),
                        "type": "array"
                    }
                }
            }

            return schemaOfSchema;
        }

        Alpaca.Field.prototype.getOptionsForSchema = function () {
            var schemaOfOptions = {
                "title": this.getTitle(),
                "description": this.getDescription() + " (Options)",
                "type": "object",
                "properties": {
                    "renderForm": {},
                    "form": {},
                    "id": {
                        "title": Globalize.localize("Alpaca.Field.Id.Title"),
                        "description": Globalize.localize("Alpaca.Field.Id.Description"),
                        "type": "string"
                    },
                    "type": {
                        "title": Globalize.localize("Alpaca.Field.Type.Title"),
                        "description": Globalize.localize("Alpaca.Field.SchemaOfOptions.Type.Description"),
                        "type": "string",
                        "default": this.getFieldType(),
                        "readonly": true
                    },
                    "validate": {
                        "title": Globalize.localize("Alpaca.Field.Validate.Title"),
                        "description": Globalize.localize("Alpaca.Field.Validate.Description"),
                        "type": "boolean",
                        "default": true
                    },
                    "showMessages": {
                        "title": Globalize.localize("Alpaca.Field.ShowMessages.Title"),
                        "description": Globalize.localize("Alpaca.Field.ShowMessages.Description"),
                        "type": "boolean",
                        "default": true
                    },
                    "disabled": {
                        "title": Globalize.localize("Alpaca.Field.Disabled.Title"),
                        "description": Globalize.localize("Alpaca.Field.Disabled.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "readonly": {
                        "title": Globalize.localize("Alpaca.Field.Readonly.Title"),
                        "description": Globalize.localize("Alpaca.Field.SchemaOfOptions.Readonly.Description"),
                        "type": "boolean",
                        "default": false,
                        "rightLabel" : "Hola!"
                    },
                    "hidden": {
                        "title": Globalize.localize("Alpaca.Field.Hidden.Title"),
                        "description": Globalize.localize("Alpaca.Field.Hidden.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "label": {
                        "title": Globalize.localize("Alpaca.Field.Label.Title"),
                        "description": Globalize.localize("Alpaca.Field.Label.Description"),
                        "type": "string"
                    },
                    "helper": {
                        "title": Globalize.localize("Alpaca.Field.Helper.Title"),
                        "description": Globalize.localize("Alpaca.Field.Helper.Description"),
                        "type": "string"
                    },
                    "fieldClass": {
                        "title": Globalize.localize("Alpaca.Field.FieldClass.Title"),
                        "description": Globalize.localize("Alpaca.Field.FieldClass.Description"),
                        "type": "string"
                    },
                    "hideInitValidationError": {
                        "title": Globalize.localize("Alpaca.Field.HideInitValidationError.Title"),
                        "description": Globalize.localize("Alpaca.Field.HideInitValidationError.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "focus": {
                        "title": Globalize.localize("Alpaca.Field.Focus.Title"),
                        "description": Globalize.localize("Alpaca.Field.Focus.Description"),
                        "type": "checkbox",
                        "default": true
                    },
                    "optionLabels": {
                        "title": Globalize.localize("Alpaca.Field.OptionLabels.Title"),
                        "description": Globalize.localize("Alpaca.Field.OptionLabels.Description"),
                        "type": "array"
                    }
                }
            };
            return schemaOfOptions;
        }

        Alpaca.ControlField.prototype.getSchemaOfSchema = function () {
            return Alpaca.merge(Alpaca.Field.prototype.getSchemaOfSchema(), {
                "properties": {
                    "enum": {
                        "title": Globalize.localize("Alpaca.ControlField.Enum.Title"),
                        "description": Globalize.localize("Alpaca.ControlField.Enum.Description"),
                        "type": "array"
                    }
                }
            });
        }

        Alpaca.ControlField.prototype.getOptionsForSchema = function () {
            return Alpaca.merge(Alpaca.Field.prototype.getSchemaOfSchema(), {
                "properties": {
                    "name": {
                        "title": Globalize.localize("Alpaca.ControlField.Name.Title"),
                        "description": Globalize.localize("Alpaca.ControlField.Name.Description"),
                        "type": "string"
                    }
                }
            });
        }

        Alpaca.ContainerField.prototype.getSchemaOfSchema = function ()
        {
            return Alpaca.merge(Alpaca.Field.prototype.getSchemaOfSchema(), {
                "properties": {
                    "lazyLoading": {
                        "title": Globalize.localize("Alpaca.ContainerField.LazyLoading.Title"),
                        "description": Globalize.localize("Alpaca.ContainerField.LazyLoading.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "collapsible": {
                        "title": Globalize.localize("Alpaca.ContainerField.Collapsible.Title"),
                        "description": Globalize.localize("Alpaca.ContainerField.Collapsible.Description"),
                        "type": "boolean",
                        "default": true
                    },
                    "collapsed": {
                        "title": Globalize.localize("Alpaca.ContainerField.Collapsed.Title"),
                        "description": Globalize.localize("Alpaca.ContainerField.Collapsed.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "legendStyle": {
                        "title": Globalize.localize("Alpaca.ContainerField.LegendStyle.Title"),
                        "description": Globalize.localize("Alpaca.ContainerField.LegendStyle.Description"),
                        "type": "string",
                        "enum": ["button", "link"],
                        "default": "button"
                    }
                }
            });
        }

        Alpaca.ContainerField.prototype.getOptionsForOptions = function ()
        {
            return Alpaca.merge(Alpaca.Field.prototype.getSchemaOfSchema(), {
                "fields": {
                    "lazyLoading": {
                        "rightLabel": Globalize.localize("Alpaca.ContainerField.LazyLoading.RightLabel"),
                        "helper": Globalize.localize("Alpaca.ContainerField.LazyLoading.Helper"),
                        "type": "checkbox"
                    },
                    "collapsible": {
                        "rightLabel": Globalize.localize("Alpaca.ContainerField.Collapsible.RightLabel"),
                        "helper": Globalize.localize("Alpaca.ContainerField.Collapsible.Helper"),
                        "type": "checkbox"
                    },
                    "collapsed": {
                        "rightLabel": Globalize.localize("Alpaca.ContainerField.Collapsed.RightLabel"),
                        "description": Globalize.localize("Alpaca.ContainerField.Collapsed.Description"),
                        "type": "checkbox"
                    },
                    "legendStyle": {
                        "type": "select"
                    }
                }
            });
        }

        Alpaca.Fields.TextField.prototype.getSchemaOfSchema = function () {
            return Alpaca.merge(Alpaca.ControlField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "minLength": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.MinLength.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.MinLength.Description"),
                        "type": "number"
                    },
                    "maxLength": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.MaxLength.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.MaxLength.Description"),
                        "type": "number"
                    },
                    "pattern": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.Pattern.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.Pattern.Description"),
                        "type": "string"
                    }
                }
            });
        }

        Alpaca.Fields.TextField.prototype.getOptionsForSchema = function () {
            return Alpaca.merge(Alpaca.ControlField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "size": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.Size.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.Size.Description"),
                        "type": "number",
                        "default": 40
                    },
                    "maskString": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.MaskString.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.MaskString.Description"),
                        "type": "string"
                    },
                    "placeholder": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.Placeholder.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.Placeholder.Description"),
                        "type": "string"
                    },                    
                    "allowOptionalEmpty": {
                        "title": Globalize.localize("Alpaca.Fields.TextField.AllowOptionalEmpty.Title"),
                        "description": Globalize.localize("Alpaca.Fields.TextField.AllowOptionalEmpty.Description")
                    }
                }
            });
        }

        Alpaca.Fields.NumberField.prototype.getSchemaOfSchema = function () {
            return Alpaca.merge(Alpaca.Fields.TextField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "multipleOf": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.MultipleOf.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.MultipleOf.Description"),
                        "type": "number"
                    },
                    "minimum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.Minimum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.Minimum.Description"),
                        "type": "number"
                    },
                    "maximum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.Maximum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.Maximum.Description"),
                        "type": "number"
                    },
                    "exclusiveMinimum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMinimum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMinimum.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "exclusiveMaximum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMaximum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMaximum.Description"),
                        "type": "boolean",
                        "default": false
                    }
                }
            });
        }

        Alpaca.Fields.NumberField.prototype.getOptionsForSchema = function () {
            return Alpaca.merge(Alpaca.Fields.TextField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "multipleOf": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.MultipleOf.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.MultipleOf.Description"),
                        "type": "number"
                    },
                    "minimum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.Minimum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.Minimum.Description"),
                        "type": "number"
                    },
                    "maximum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.Maximum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.Maximum.Description"),
                        "type": "number"
                    },
                    "exclusiveMinimum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMinimum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMinimum.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "exclusiveMaximum": {
                        "title": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMaximum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.NumberField.ExclusiveMaximum.Description"),
                        "type": "boolean",
                        "default": false
                    }
                }
            });
        }

        Alpaca.Fields.ArrayField.prototype.getSchemaOfSchema = function () {
            var properties = {
                "properties": {
                    "items": {
                        "title": Globalize.localize("Alpaca.Fields.ArrayField.Items.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ArrayField.Items.SchemaOfSchema.Description"),
                        "type": "object",
                        "properties": {
                            "minItems": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.Items.MinItems.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.Items.MinItems.Description"),
                                "type": "number"
                            },
                            "maxItems": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.Items.MaxItems.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.Items.MaxItems.Description"),
                                "type": "number"
                            },
                            "uniqueItems": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.Items.UniqueItems.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.Items.UniqueItems.Description"),
                                "type": "boolean",
                                "default": false
                            }
                        }
                    }
                }
            }
            return properties;
        }

        Alpaca.Fields.ArrayField.prototype.getOptionsForSchema = function () {
            var properties = {
                "properties": {
                    "toolbarSticky": {
                        "title": Globalize.localize("Alpaca.Fields.ArrayField.ToolbarSticky.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ArrayField.ToolbarSticky.Description"),
                        "type": "boolean",
                        "default": false
                    },
                    "items": {
                        "title": Globalize.localize("Alpaca.Fields.ArrayField.Items.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ArrayField.Items.SchemaOfOptions.Description"),
                        "type": "object",
                        "properties": {
                            "extraToolbarButtons": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.ExtraToolbarButtons.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.ExtraToolbarButtons.Description"),
                                "type": "array",
                                "default": undefined
                            },
                            "moveUpItemLabel": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.MoveUpItemLabel.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.MoveUpItemLabel.Description"),
                                "type": "string",
                                "default": Globalize.localize("Alpaca.Fields.ArrayField.MoveUpItemLabel.Default")
                            },
                            "moveDownItemLabel": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.MoveDownItemLabel.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.MoveDownItemLabel.Description"),
                                "type": "string",
                                "default": Globalize.localize("Alpaca.Fields.ArrayField.MoveDownItemLabel.Default")
                            },
                            "removeItemLabel": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.RemoveItemLabel.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.RemoveItemLabel.Description"),
                                "type": "string",
                                "default": Globalize.localize("Alpaca.Fields.ArrayField.RemoveItemLabel.Default")
                            },
                            "addItemLabel": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.AddItemLabel.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.AddItemLabel.Description"),
                                "type": "string",
                                "default": Globalize.localize("Alpaca.Fields.ArrayField.RemoveItemLabel.Default")
                            },
                            "showMoveDownItemButton": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.ShowMoveDownItemButton.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.ShowMoveDownItemButton.Description"),
                                "type": "boolean",
                                "default": true
                            },
                            "showMoveUpItemButton": {
                                "title": Globalize.localize("Alpaca.Fields.ArrayField.ShowMoveUpItemButton.Title"),
                                "description": Globalize.localize("Alpaca.Fields.ArrayField.ShowMoveUpItemButton.Description"),
                                "type": "boolean",
                                "default": true
                            }
                        }
                    }
                }
            }
            return properties;
        }

        Alpaca.Fields.CheckBoxField.prototype.getSchemaOfSchema = function () {
            return Alpaca.merge(Alpaca.ControlField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "rightLabel": {
                        "title": Globalize.localize("Alpaca.Fields.CheckBoxField.RightLabel.Title"),
                        "description": Globalize.localize("Alpaca.Fields.CheckBoxField.RightLabel.Description"),
                        "type": "string"
                    },
                    "multiple": {
                        "title": Globalize.localize("Alpaca.Fields.CheckBoxField.Multiple.Title"),
                        "description": Globalize.localize("Alpaca.Fields.CheckBoxField.Multiple.Description"),
                        "type": "boolean"
                    }
                }
            });
        }

        Alpaca.Fields.FileField.prototype.getOptionsForSchema = function () {
            return Alpaca.merge(Alpaca.Fields.TextField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "selectionHandler": {
                        "title": Globalize.localize("Alpaca.Fields.FileField.SelectionHandler.Title"),
                        "description": Globalize.localize("Alpaca.Fields.FileField.SelectionHandler.Description"),
                        "type": "boolean",
                        "default": false
                    }
                }
            });
        }

        Alpaca.Fields.ListField.prototype.getSchemaOfSchema = function () {
            return Alpaca.merge(Alpaca.ControlField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "enum": {
                        "title": Globalize.localize("Alpaca.Fields.ListField.Enum.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ListField.Enum.Description"),
                        "type": "array",
                        "required": true
                    }
                }
            });
        }

        Alpaca.Fields.ListField.prototype.getSchemaOfOptions = function () {
            return Alpaca.merge(Alpaca.ControlField.prototype.getSchemaOfSchema(), {
                "properties": {
                    "optionLabels": {
                        "title": Globalize.localize("Alpaca.Fields.ListField.OptionLabels.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ListField.OptionLabels.Description"),
                        "type": "array"
                    },
                    "dataSource": {
                        "title": Globalize.localize("Alpaca.Fields.ListField.DataSource.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ListField.DataSource.Description"),
                        "type": "string"
                    },
                    "removeDefaultNone": {
                        "title": Globalize.localize("Alpaca.Fields.ListField.RemoveDefaultNone.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ListField.RemoveDefaultNone.Description"),
                        "type": "boolean",
                        "default": false
                    }
                }
            });
        }

        Alpaca.Fields.ObjectField.prototype.getSchemaOfOptions = function () {
            var properties = {
                "properties": {
                    "properties": {
                        "title": Globalize.localize("Alpaca.Fields.ObjectField.Properties.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ObjectField.Properties.Description"),
                        "type": "object"
                    },
                    "maxProperties": {
                        "type": "number",
                        "title": Globalize.localize("Alpaca.Fields.ObjectField.MaxProperties.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ObjectField.MaxProperties.Description")
                    },
                    "minProperties": {
                        "type": "number",
                        "title": Globalize.localize("Alpaca.Fields.ObjectField.MinProperties.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ObjectField.MinProperties.Description")
                    }
                }
            }
            return properties;
        }

        Alpaca.Fields.ObjectField.prototype.getSchemaOfOptions = function ()
        {
            var schemaOfOptions = Alpaca.merge(Alpaca.ContainerField.prototype.getSchemaOfSchema(), {
                "properties": {
                }
            });

            var properties = {
                "properties": {
                    "fields": {
                        "title": Globalize.localize("Alpaca.Fields.ObjectField.Fields.Title"),
                        "description": Globalize.localize("Alpaca.Fields.ObjectField.Fields.Description"),
                        "type": "object"
                    }
                }
            }
            return properties;
        }

        Alpaca.Fields.RadioField.prototype.getSchemaOfSchema = function ()
        {
            return Alpaca.merge(this.base(), {
                "properties": {
                    "name": {
                        "title": "Field name",
                        "description": "Field name.",
                        "type": "string"
                    },
                    "emptySelectFirst": {
                        "title": "Empty Select First",
                        "description": "If the data is empty, then automatically select the first item in the list.",
                        "type": "boolean",
                        "default": false
                    },
                    "vertical": {
                        "title": "Position the radio selector items vertically",
                        "description": "When true, the radio selector items will be stacked vertically and not horizontally",
                        "type": "boolean",
                        "default": false
                    }
                }
            });
        }

    }
}

DocumentManager.Designer.Scripts.Designer.descriptor = {
    properties: [{ name: '_types', type: Object },
                    { name: '_data', type: String },
                    { name: '_schema', type: String },
                    { name: '_options', type: String }]
}

DocumentManager.Designer.Scripts.Designer.registerClass('DocumentManager.Designer.Scripts.Designer', Sys.UI.Control);

// Since this script is not loaded by System.Web.Handlers.ScriptResourceHandler
// invoke Sys.Application.notifyScriptLoaded to notify ScriptManager 
// that this is the end of the script.
if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();
