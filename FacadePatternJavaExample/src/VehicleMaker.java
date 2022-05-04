
public class VehicleMaker {
	 private Vehicle car;
	 private Vehicle truck;
	 private Vehicle motobike;

	public VehicleMaker() {
	    car = new Car();
	    truck = new Truck();
	    motobike = new Motobike();
	 }
	public void startCar(){
	      car.start();
	   }
	public void startTruck(){
	      truck.start();
	   }
   public void startMotobike(){
		   motobike.start();
	   }
	public void stopCar(){
		      car.stop();
		   }
	public void stopTruck(){
		      truck.stop();
		   }
	public void stopMotobike(){
			   motobike.stop();
		   }
}
