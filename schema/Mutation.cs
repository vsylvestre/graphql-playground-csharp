using HotChocolate;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System.Threading.Tasks;

namespace Playground
{
    public class Mutation
    {
        public async Task<bool> UpdateValue([Service]ITopicEventSender eventSender)
        {
            await eventSender.SendAsync(SubscriptionConstants.ValueUpdated, "New value");

            return true;
        }
    }
}