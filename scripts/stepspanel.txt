
class StepsSteeringSteppable(SteppableBasePy):
    steps = 10000

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='steps', val=self.steps, min_val=0, max_val=100000, widget_name='slider')

    def process_steering_panel_data(self):
        print "StepsSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED"
        print 'all dirty flag=', self.steering_param_dirty()
        self.steps = self.get_steering_param('steps')
        self.setXMLElementValue(self.steps, ['Potts'], ['Steps'])
        self.updateXML()
        print 'steps=', self.steps