
public class FacadePatternDemo {
	public static void main(String[] args) {
	      VehicleMaker vehicleMaker = new VehicleMaker();

	      vehicleMaker.startCar();
	      vehicleMaker.startMotobike();
	      vehicleMaker.startTruck();		

	      vehicleMaker.stopCar();
	      vehicleMaker.stopMotobike();
	      vehicleMaker.stopTruck();
	   }
}
