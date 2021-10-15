
class VolumeSteeringSteppable(SteppableBasePy):
    targetVolume = 25
    lambdaVolume = 2.0

    def __init__(self, _simulator, _frequency=10):
        SteppableBasePy.__init__(self, _simulator, _frequency)

    def add_steering_panel(self):
        self.add_steering_param(name='target_vol', val=self.targetVolume, min_val=0, max_val=100, widget_name='slider')
        self.add_steering_param(name='lambda_vol', val=self.lambdaVolume, min_val=0, max_val=10.0, decimal_precision=2, widget_name='slider')

    def process_steering_panel_data(self):
        print "VolumeSteeringSteppable: WILL ADJUST PARAMETERS BECAUSE AT LEAST ONE STEERING PARAMETER HAS BEEN CHANGED"
        print 'all dirty flag=', self.steering_param_dirty()
        self.targetVolume = self.get_steering_param('target_vol')
        self.lambdaVolume = self.get_steering_param('lambda_vol')

        for cell in self.cellList:
            cell.targetVolume = self.targetVolume
            cell.lambdaVolume = self.lambdaVolume
        print 'target_volume=', self.targetVolume
        print 'lambda_volume=', self.lambdaVolume
