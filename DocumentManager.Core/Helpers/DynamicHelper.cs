using System;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace DocumentManager.Core.Helpers
{
    public static class DynamicHelper {
        public static object GetValue(object dyn, string propName)
        {
            var GetterSite = CallSite<Func<CallSite, object, object>>.Create(
                    Binder.GetMember(CSharpBinderFlags.None,
                        propName,
                        dyn.GetType(),
                        new[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }
                        ));

            return GetterSite.Target(GetterSite, dyn);
        }

        public static void SetValue(object dyn, string propName, object val)
        {
            var SetterSite = CallSite<Func<CallSite, object, object, object>>.Create(
                    Binder.SetMember(CSharpBinderFlags.None,
                        propName,
                        dyn.GetType(),
                        new[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant |
                                            CSharpArgumentInfoFlags.UseCompileTimeType, null) }
                        ));

            SetterSite.Target(SetterSite, dyn, val);
        }
    }
}
