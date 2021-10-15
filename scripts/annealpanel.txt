
class AnnealSteeringSteppable(SteppableBasePy):
    anneal = 10

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='anneal', val=self.anneal, min_val=0, max_val=100, widget_name='slider')

    def process_steering_panel_data(self):
        print "StepsSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED"
        print 'all dirty flag=', self.steering_param_dirty()
        self.anneal = self.get_steering_param('anneal')
        self.setXMLElementValue(self.anneal, ['Potts'], ['Anneal'])
        self.updateXML()
        print 'anneal=', self.anneal