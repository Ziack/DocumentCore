namespace DocumentManager.Core.Workflows {
    
    #line 24 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 25 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 26 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 27 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 28 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.ServiceModel.Activities;
    
    #line default
    #line hidden
    
    #line 30 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 31 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using DocumentManager.Core.Workflows;
    
    #line default
    #line hidden
    
    #line 32 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using DocumentManager;
    
    #line default
    #line hidden
    
    #line 33 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using DocumentManager.Core.Schema;
    
    #line default
    #line hidden
    
    #line 34 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using Facture.AppFabric.ActivityLibrary.Extensions;
    
    #line default
    #line hidden
    
    #line 35 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using DocumentManager.Base;
    
    #line default
    #line hidden
    
    #line 1 "C:\inetpub\dotnetnuke\FactureSource\Modulos\DocumentManager\DocumentManager.Core\Workflows\ApprovalWorklow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class ApprovalWorklow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = ApprovalWorklow_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApprovalWorklow_TypedDataContext2(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext2 refDataContext0 = ((ApprovalWorklow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ApprovalWorklow_TypedDataContext2(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext2 refDataContext1 = ((ApprovalWorklow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<long>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext2 = ((ApprovalWorklow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext3 = ((ApprovalWorklow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext4 = ((ApprovalWorklow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new ApprovalWorklow_TypedDataContext5(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext5 refDataContext5 = ((ApprovalWorklow_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ApprovalWorklow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext3_ForReadOnly valDataContext6 = ((ApprovalWorklow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new ApprovalWorklow_TypedDataContext6(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext6 refDataContext7 = ((ApprovalWorklow_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext7.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext8 = ((ApprovalWorklow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ApprovalWorklow_TypedDataContext7(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7 refDataContext9 = ((ApprovalWorklow_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext9.GetLocation<System.Collections.Generic.List<string>>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ApprovalWorklow_TypedDataContext7(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7 refDataContext10 = ((ApprovalWorklow_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext11 = ((ApprovalWorklow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext12 = ((ApprovalWorklow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext13 = ((ApprovalWorklow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ApprovalWorklow_TypedDataContext7(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7 refDataContext14 = ((ApprovalWorklow_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext14.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext15 = ((ApprovalWorklow_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ApprovalWorklow_TypedDataContext7(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext7 refDataContext16 = ((ApprovalWorklow_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext16.GetLocation<bool>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new ApprovalWorklow_TypedDataContext8(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext8 refDataContext17 = ((ApprovalWorklow_TypedDataContext8)(cachedCompiledDataContext[7]));
                return refDataContext17.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new ApprovalWorklow_TypedDataContext9(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9 refDataContext18 = ((ApprovalWorklow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext18.GetLocation<object>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new ApprovalWorklow_TypedDataContext9(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9 refDataContext19 = ((ApprovalWorklow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new ApprovalWorklow_TypedDataContext9(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9 refDataContext20 = ((ApprovalWorklow_TypedDataContext9)(cachedCompiledDataContext[8]));
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext21 = ((ApprovalWorklow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext22 = ((ApprovalWorklow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext23 = ((ApprovalWorklow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext24 = ((ApprovalWorklow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext25 = ((ApprovalWorklow_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ApprovalWorklow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ApprovalWorklow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ApprovalWorklow_TypedDataContext3_ForReadOnly valDataContext26 = ((ApprovalWorklow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext26.ValueType___Expr26Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                ApprovalWorklow_TypedDataContext2 refDataContext0 = new ApprovalWorklow_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                ApprovalWorklow_TypedDataContext2 refDataContext1 = new ApprovalWorklow_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<long>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext2 = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext3 = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                ApprovalWorklow_TypedDataContext2_ForReadOnly valDataContext4 = new ApprovalWorklow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                ApprovalWorklow_TypedDataContext5 refDataContext5 = new ApprovalWorklow_TypedDataContext5(locations, true);
                return refDataContext5.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                ApprovalWorklow_TypedDataContext3_ForReadOnly valDataContext6 = new ApprovalWorklow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                ApprovalWorklow_TypedDataContext6 refDataContext7 = new ApprovalWorklow_TypedDataContext6(locations, true);
                return refDataContext7.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext8 = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                ApprovalWorklow_TypedDataContext7 refDataContext9 = new ApprovalWorklow_TypedDataContext7(locations, true);
                return refDataContext9.GetLocation<System.Collections.Generic.List<string>>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                ApprovalWorklow_TypedDataContext7 refDataContext10 = new ApprovalWorklow_TypedDataContext7(locations, true);
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext11 = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext12 = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext13 = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                ApprovalWorklow_TypedDataContext7 refDataContext14 = new ApprovalWorklow_TypedDataContext7(locations, true);
                return refDataContext14.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                ApprovalWorklow_TypedDataContext7_ForReadOnly valDataContext15 = new ApprovalWorklow_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                ApprovalWorklow_TypedDataContext7 refDataContext16 = new ApprovalWorklow_TypedDataContext7(locations, true);
                return refDataContext16.GetLocation<bool>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                ApprovalWorklow_TypedDataContext8 refDataContext17 = new ApprovalWorklow_TypedDataContext8(locations, true);
                return refDataContext17.GetLocation<DocumentManager.Base.DocumentContent>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                ApprovalWorklow_TypedDataContext9 refDataContext18 = new ApprovalWorklow_TypedDataContext9(locations, true);
                return refDataContext18.GetLocation<object>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                ApprovalWorklow_TypedDataContext9 refDataContext19 = new ApprovalWorklow_TypedDataContext9(locations, true);
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                ApprovalWorklow_TypedDataContext9 refDataContext20 = new ApprovalWorklow_TypedDataContext9(locations, true);
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext21 = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext22 = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext23 = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext24 = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                ApprovalWorklow_TypedDataContext9_ForReadOnly valDataContext25 = new ApprovalWorklow_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                ApprovalWorklow_TypedDataContext3_ForReadOnly valDataContext26 = new ApprovalWorklow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "Content") 
                        && (ApprovalWorklow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "DocumentId") 
                        && (ApprovalWorklow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Content") 
                        && (ApprovalWorklow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DocumentId") 
                        && (ApprovalWorklow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new ValidationResult()") 
                        && (ApprovalWorklow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ValidationResult.ErrorMessages") 
                        && (ApprovalWorklow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "ValidationResult.IsValid") 
                        && (ApprovalWorklow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ValidationResult.IsValid") 
                        && (ApprovalWorklow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "ValidationResult") 
                        && (ApprovalWorklow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsIssued") 
                        && (ApprovalWorklow_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "DocumentId") 
                        && (ApprovalWorklow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "IsRevoked") 
                        && (ApprovalWorklow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RevokeMessage") 
                        && (ApprovalWorklow_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Document") 
                        && (ApprovalWorklow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "DocumentId") 
                        && (ApprovalWorklow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsRevoked") 
                        && (ApprovalWorklow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RevokeMessage") 
                        && (ApprovalWorklow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "IsRevoked") 
                        && (ApprovalWorklow_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!IsIssued") 
                        && (ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new ApprovalWorklow_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new ApprovalWorklow_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new ApprovalWorklow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new ApprovalWorklow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new ApprovalWorklow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new ApprovalWorklow_TypedDataContext5(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new ApprovalWorklow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new ApprovalWorklow_TypedDataContext6(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new ApprovalWorklow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new ApprovalWorklow_TypedDataContext7(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new ApprovalWorklow_TypedDataContext7(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new ApprovalWorklow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new ApprovalWorklow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new ApprovalWorklow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new ApprovalWorklow_TypedDataContext7(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new ApprovalWorklow_TypedDataContext7_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new ApprovalWorklow_TypedDataContext7(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new ApprovalWorklow_TypedDataContext8(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new ApprovalWorklow_TypedDataContext9(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new ApprovalWorklow_TypedDataContext9(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new ApprovalWorklow_TypedDataContext9(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new ApprovalWorklow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new ApprovalWorklow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new ApprovalWorklow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new ApprovalWorklow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new ApprovalWorklow_TypedDataContext9_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new ApprovalWorklow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext1 : ApprovalWorklow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected DocumentManager.Base.DocumentContent Document {
                get {
                    return ((DocumentManager.Base.DocumentContent)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string Guid {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Document") 
                            || (locationReferences[(offset + 0)].Type != typeof(DocumentManager.Base.DocumentContent)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Guid") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext1_ForReadOnly : ApprovalWorklow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected DocumentManager.Base.DocumentContent Document {
                get {
                    return ((DocumentManager.Base.DocumentContent)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string Guid {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Document") 
                            || (locationReferences[(offset + 0)].Type != typeof(DocumentManager.Base.DocumentContent)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Guid") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext2 : ApprovalWorklow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected long DocumentId;
            
            public ApprovalWorklow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Content {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 78 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Content;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 78 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
              Content;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(string value) {
                
                #line 78 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
              Content = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 88 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
              DocumentId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr1Get() {
                
                #line 88 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
              DocumentId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(long value) {
                
                #line 88 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
              DocumentId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(long value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.DocumentId = ((long)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.DocumentId);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "Content") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "DocumentId") 
                            || (locationReferences[(offset + 2)].Type != typeof(long)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext2_ForReadOnly : ApprovalWorklow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected long DocumentId;
            
            public ApprovalWorklow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Content {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 83 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
              Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr2Get() {
                
                #line 83 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
              Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 100 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  Content;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 100 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                  Content;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 97 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<long>> expression = () => 
                  DocumentId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public long @__Expr4Get() {
                
                #line 97 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                  DocumentId;
                
                #line default
                #line hidden
            }
            
            public long ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            protected override void GetValueTypeValues() {
                this.DocumentId = ((long)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "Content") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "DocumentId") 
                            || (locationReferences[(offset + 2)].Type != typeof(long)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext3 : ApprovalWorklow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsIssued;
            
            public ApprovalWorklow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.IsIssued = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.IsIssued);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "IsIssued") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext3_ForReadOnly : ApprovalWorklow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsIssued;
            
            public ApprovalWorklow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 153 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                              Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr6Get() {
                
                #line 153 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 111 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                    !IsIssued;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr26Get() {
                
                #line 111 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                    !IsIssued;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            protected override void GetValueTypeValues() {
                this.IsIssued = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "IsIssued") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext4 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Planning_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Planning_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext4_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Planning_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Planning_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext5 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Save_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 140 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr5Get() {
                
                #line 140 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(DocumentManager.Base.DocumentContent value) {
                
                #line 140 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                Document = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(DocumentManager.Base.DocumentContent value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Save_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext5_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Save_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Save_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext6 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> issue_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 168 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr7Get() {
                
                #line 168 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(DocumentManager.Base.DocumentContent value) {
                
                #line 168 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                Document = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(DocumentManager.Base.DocumentContent value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "issue_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext6_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> issue_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "issue_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext7 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected DocumentManager.Core.Workflows.ValidationResult ValidationResult {
                get {
                    return ((DocumentManager.Core.Workflows.ValidationResult)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 195 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<string>>> expression = () => 
                                  ValidationResult.ErrorMessages;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<string> @__Expr9Get() {
                
                #line 195 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                  ValidationResult.ErrorMessages;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<string> ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(System.Collections.Generic.List<string> value) {
                
                #line 195 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                  ValidationResult.ErrorMessages = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(System.Collections.Generic.List<string> value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 200 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ValidationResult.IsValid;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 200 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                  ValidationResult.IsValid;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(bool value) {
                
                #line 200 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                  ValidationResult.IsValid = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 219 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                          Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr14Get() {
                
                #line 219 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                          Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(DocumentManager.Base.DocumentContent value) {
                
                #line 219 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                          Document = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(DocumentManager.Base.DocumentContent value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 228 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              IsIssued;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 228 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                              IsIssued;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(bool value) {
                
                #line 228 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                              IsIssued = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ValidationResult") 
                            || (locationReferences[(offset + 5)].Type != typeof(DocumentManager.Core.Workflows.ValidationResult)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext7_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected DocumentManager.Core.Workflows.ValidationResult ValidationResult {
                get {
                    return ((DocumentManager.Core.Workflows.ValidationResult)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 181 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Core.Workflows.ValidationResult>> expression = () => 
                              new ValidationResult();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Core.Workflows.ValidationResult @__Expr8Get() {
                
                #line 181 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              new ValidationResult();
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Core.Workflows.ValidationResult ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 190 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                  Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr11Get() {
                
                #line 190 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                  Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 207 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                  ValidationResult.IsValid;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr12Get() {
                
                #line 207 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                  ValidationResult.IsValid;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 240 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Core.Workflows.ValidationResult>> expression = () => 
                                                  ValidationResult;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Core.Workflows.ValidationResult @__Expr13Get() {
                
                #line 240 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                                  ValidationResult;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Core.Workflows.ValidationResult ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 214 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                          Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr15Get() {
                
                #line 214 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                          Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "ValidationResult") 
                            || (locationReferences[(offset + 5)].Type != typeof(DocumentManager.Core.Workflows.ValidationResult)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext8 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Revoke_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 273 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                                Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr17Get() {
                
                #line 273 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                                Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(DocumentManager.Base.DocumentContent value) {
                
                #line 273 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                                Document = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(DocumentManager.Base.DocumentContent value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Revoke_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext8_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ApprovalWorklow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.Dictionary<string, object> Revoke_Input {
                get {
                    return ((System.Collections.Generic.Dictionary<string, object>)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "Revoke_Input") 
                            || (locationReferences[(offset + 5)].Type != typeof(System.Collections.Generic.Dictionary<string, object>)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext9 : ApprovalWorklow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsRevoked;
            
            public ApprovalWorklow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RevokeMessage {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected new object DocumentId {
                get {
                    return ((object)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 301 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                              DocumentId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr18Get() {
                
                #line 301 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              DocumentId;
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(object value) {
                
                #line 301 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                              DocumentId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(object value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 306 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsRevoked;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 306 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              IsRevoked;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(bool value) {
                
                #line 306 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                              IsRevoked = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 296 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RevokeMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 296 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              RevokeMessage;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(string value) {
                
                #line 296 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                
                              RevokeMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.IsRevoked = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.IsRevoked);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 6)].Name != "RevokeMessage") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "DocumentId") 
                            || (locationReferences[(offset + 7)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "IsRevoked") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ApprovalWorklow_TypedDataContext9_ForReadOnly : ApprovalWorklow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool IsRevoked;
            
            public ApprovalWorklow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ApprovalWorklow_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string RevokeMessage {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected new object DocumentId {
                get {
                    return ((object)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 291 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<DocumentManager.Base.DocumentContent>> expression = () => 
                              Document;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public DocumentManager.Base.DocumentContent @__Expr21Get() {
                
                #line 291 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              Document;
                
                #line default
                #line hidden
            }
            
            public DocumentManager.Base.DocumentContent ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 313 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<object>> expression = () => 
                              DocumentId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public object @__Expr22Get() {
                
                #line 313 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              DocumentId;
                
                #line default
                #line hidden
            }
            
            public object ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 323 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsRevoked;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 323 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              IsRevoked;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 318 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              RevokeMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 318 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              RevokeMessage;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 330 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              IsRevoked;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 330 "C:\INETPUB\DOTNETNUKE\FACTURESOURCE\MODULOS\DOCUMENTMANAGER\DOCUMENTMANAGER.CORE\WORKFLOWS\APPROVALWORKLOW.XAML"
                return 
                              IsRevoked;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            protected override void GetValueTypeValues() {
                this.IsRevoked = ((bool)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 8))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 8);
                }
                expectedLocationsCount = 8;
                if (((locationReferences[(offset + 6)].Name != "RevokeMessage") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "DocumentId") 
                            || (locationReferences[(offset + 7)].Type != typeof(object)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "IsRevoked") 
                            || (locationReferences[(offset + 5)].Type != typeof(bool)))) {
                    return false;
                }
                return ApprovalWorklow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
