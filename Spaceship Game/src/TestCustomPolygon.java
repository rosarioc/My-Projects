
public class TestCustomPolygon {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int polyx[] = { 50, 50, 150, 150 };
		int polyy[] = { 100, 150, 200, 80 };
		int npoly = 4;
		
		CustomPolygon poly = new CustomPolygon(polyx, polyy, npoly);

		
		int temp[] = new int[10]; 
		
		//deep copy
//		for (int i = 0; i<4; i++){
//			temp[i] = poly.getXCords(i);
//		}
		
		poly.translate(50, 50);
		
		for(int i = 0; i<4; i++){
			System.out.println(poly.xpoints[i]);
			System.out.println(poly.ypoints[i]);
		
		}

		System.out.println(poly.npoints);
	}

}
