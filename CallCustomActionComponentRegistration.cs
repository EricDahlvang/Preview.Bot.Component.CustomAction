using AdaptiveExpressions.Converters;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs.Debugging;
using Microsoft.Bot.Builder.Dialogs.Declarative;
using Microsoft.Bot.Builder.Dialogs.Declarative.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Preview.Bot.Component.CustomAction
{
    public class CallCustomActionComponentRegistration : ComponentRegistration, IComponentDeclarativeTypes
    {
        public IEnumerable<DeclarativeType> GetDeclarativeTypes(ResourceExplorer resourceExplorer)
        {
            // Actions
            yield return new DeclarativeType<CallCustomCodeAction>(CallCustomCodeAction.Kind);
        }

        public IEnumerable<JsonConverter> GetConverters(ResourceExplorer resourceExplorer, SourceContext sourceContext)
        {
            return Enumerable.Empty<JsonConverter>();
        }
    }
}

