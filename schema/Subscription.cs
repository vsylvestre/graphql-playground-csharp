using HotChocolate;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Playground 
{
    public class Subscription
    {
        [SubscribeAndResolve]
        public async ValueTask<IAsyncEnumerable<string>> ValueUpdated(
            [Service]ITopicEventReceiver eventReceiver,
            string input,
            CancellationToken cancellationToken) =>
            await eventReceiver.SubscribeAsync<string, string>(SubscriptionConstants.ValueUpdated, cancellationToken);  
    }
}