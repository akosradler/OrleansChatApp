using Orleans;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Redux;

namespace OrleansChatApp.Grains
{
    public abstract class ReduxGrain<TState> : Grain where TState : class, new()
    {        
        protected Store<TState> Store { get; private set; }

        private readonly Reducer<TState> _reducer;
        private readonly ILogger _logger;

        public ReduxGrain(Reducer<TState> reducer, ILoggerFactory loggerFactory)
        {            
            _reducer = reducer;
            _logger = loggerFactory.CreateLogger<ReduxGrain<TState>>();
        }

        public Task<IAction> Dispatch(IAction action)
        {
            return Task.FromResult(Store.Dispatch(action));
        }

        public Task<TState> GetState()
        {
            return Task.FromResult(Store.GetState());
        }
    }
}
