
class NeighborOrderSteeringSteppable(SteppableBasePy):
    neighborOrder = 2

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='neighbor_order', val=self.neighborOrder, min_val=0, max_val=10, widget_name='slider')

    def process_steering_panel_data(self):
        print "NeighborOrderSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED"
        print 'all dirty flag=', self.steering_param_dirty()
        self.neighborOrder = self.get_steering_param('neighbor_order')
        self.setXMLElementValue(self.neighborOrder, ['Potts'], ['NeighborOrder'])
        self.updateXML()
        print 'neighbor_order=', self.neighborOrder