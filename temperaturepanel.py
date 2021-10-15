
class TemperatureSteeringSteppable(SteppableBasePy):
    initTemperature = 23
    initInterval = 0.011
    temperature = initTemperature
    interval = initInterval

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='temperature', val=self.initTemperature, min_val=0, max_val=100.0, decimal_precision=2, widget_name='lineedit')
        self.add_steering_param(name='interval', val=self.initInterval, min_val=0, max_val=1.0, decimal_precision=4, widget_name='lineedit')
        
    def process_steering_panel_data(self):
        print 'TemperatureSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED'
        temp = self.get_steering_param('temperature')
        if temp != self.initTemperature:
            self.initTemperature = temp
            self.temperature = temp
        temp = self.get_steering_param('interval')
        if temp != self.initInterval:
            self.initInterval = temp
            self.interval = temp

    def step(self, mcs):
        self.temperature += self.interval
        for cell in self.cellList:
            cell.fluctAmpl = self.temperature
        print 'temperature=', self.temperature