
class Flip2DimRatioSteeringSteppable(SteppableBasePy):
    flip2DimRatio = 1

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='flip2DimRatio', val=self.flip2DimRatio, min_val=0, max_val=10, widget_name='slider')

    def process_steering_panel_data(self):
        print "NeighborOrderSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED"
        print 'all dirty flag=', self.steering_param_dirty()
        self.flip2DimRatio = self.get_steering_param('flip2DimRatio')
        self.setXMLElementValue(self.flip2DimRatio, ['Potts'], ['Flip2DimRatio'])
        self.updateXML()
        print 'flip2DimRatio=', self.flip2DimRatio