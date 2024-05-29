namespace SmartLightController
{
    public class TrafficController
    {
        private readonly TrafficModel _model;
        private readonly TrafficView _view;
        private ITrafficManagementStrategy _strategy;

        public TrafficController(TrafficModel model, TrafficView view, ITrafficManagementStrategy strategy)
        {
            _model = model;
            _view = view;
            _strategy = strategy;
        }

        public void UpdateView()
        {
            _view.Display(_model.TrafficData);
        }

        public void SetStrategy(ITrafficManagementStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
            // Update the model with new traffic data based on the executed strategy...
            _model.TrafficData = "Updated traffic data based on strategy";
            UpdateView();
        }
    }
}
