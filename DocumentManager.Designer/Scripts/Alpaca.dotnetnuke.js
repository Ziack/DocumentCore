/**
 * Phone JS Theme ("phone-js")
 *
 * Defines the Alpaca theme for Phone JS.
 *
 * The style injector:
 *
 *    phone-js
 *
 * The views are:
 *
 *    VIEW_PHONEJS_DISPLAY
 *    VIEW_PHONEJS_EDIT
 *    VIEW_PHONEJS_CREATE
 *
 * This theme can be selected by specifying the following view:
 *
 *    {
 *       "ui": "phone-js",
 *       "type": null | "create" | "edit" | "display"
 *    }
 *
 */
(function($) {

    var Alpaca = $.alpaca;

    Alpaca.styleInjections["dotnetnuke"] = {
        "container" : function(targetDiv) {
            
        }        
    };

    Alpaca.registerView({
        "id": "VIEW_DOTNETNUKE_EDIT",
        "parent": "VIEW_BOOTSTRAP_EDIT",
        "title": "Web Edit View for Phone JS",
        "description":"Web Edit View for Phone JS",
        "style": "dotnetnuke",
        "ui": "dotnetnuke",
		"type": "edit",
		"templates": {
            // Templates for control fields
            "controlFieldOuterEl": null,
            "controlFieldLabel": '{{if options.label}}<div class="dnnLabel">${options.label}</div>{{/if}}',
            "controlFieldOuter": '<div class="dnnFormItem grid-100">{{html this.html}}</div>',
            "controlFieldContainer": '<div>{{html this.html}}</div>',            
            "controlFieldMessage": '<div><span class="ui-icon ui-icon-alert"></span></div>',
            "controlFieldHelper": '{{if options.helper}}<div class="{{if options.helperClass}}${options.helperClass}{{/if}}"><span class="ui-icon ui-icon-info"></span><span class="alpaca-controlfield-helper-text">${options.helper}</span></div>{{/if}}',
            "controlField":				
				'{{wrap(null, {}) Alpaca.fieldTemplate(this,"controlFieldOuter",true)}}' +
                    '{{wrap Alpaca.fieldTemplate(this,"controlFieldLabel")}}' +
                    '{{/wrap}}' +
                    '{{wrap(null, {}) Alpaca.fieldTemplate(this,"controlFieldContainer")}}' +
                    '{{/wrap}}' +
				'{{/wrap}}' ,
                
            // Templates for container fields
            "fieldSetOuterEl": '<div class="dnnForm">{{html this.html}}</div>',
            "fieldSetMessage": '<div><span class="ui-icon ui-icon-alert alpaca-fieldset-message-table-view"></span><span>${message}</span></div>',
            "fieldSetLegend": '{{if options.label}}<legend class="{{if options.labelClass}}${options.labelClass}{{/if}}">${options.label}</legend>{{/if}}',
            "fieldSetHelper": '{{if options.helper}}<div class="{{if options.helperClass}}${options.helperClass}{{/if}}">${options.helper}</div>{{/if}}',            
            "fieldSetItemsContainer": '<fieldset>{{html this.html}}</fieldset>',
            "fieldSet": '{{wrap(null, {}) Alpaca.fieldTemplate(this,"fieldSetOuterEl",true)}}{{html Alpaca.fieldTemplate(this,"fieldSetLegend")}}{{html Alpaca.fieldTemplate(this,"fieldSetHelper")}}{{wrap(null, {}) Alpaca.fieldTemplate(this,"fieldSetItemsContainer",true)}}{{/wrap}}{{/wrap}}',            
            "formButtonsContainer": '<div>{{if options.buttons}}{{each(k,v) options.buttons}}<div data-bind="dxButton: { text: \'${v.value}\', {{if v.clickAction}}clickAction: ${v.clickAction} {{/if}} }" data-key="${k}" ></div>{{/each}}{{/if}}</div>',
            "controlFieldCheckbox": '{{if options.rightLabel}}<label for="${id}_checkbox">{{/if}}<input id="${id}_checkbox" type="checkbox" {{if options.readonly}}readonly="readonly"{{/if}} {{if name}}name="${name}"{{/if}} {{each(i,v) options.data}}data-${i}="${v}"{{/each}}/>{{if options.rightLabel}}${options.rightLabel}</label>{{/if}}',
            "fieldSetItemContainer": '',
        },
        "styles": {
        }
    });			
})(jQuery);