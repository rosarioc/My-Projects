import java.awt.Polygon;


public class CustomPolygon extends Polygon{
	
//	public int xpoints[];
//	public int ypoints[];
//	public int n;
	
	public CustomPolygon(int xpoints[], int ypoints[], int n){
		super(xpoints, ypoints, n);
		
	}
	
	public int getXCords(int i){
		return xpoints[i];
	
	}
	
	public int[] getYCords(){
		return ypoints;
	}
	
	public int getVertices(){
		return npoints;
	}
	
	public void resetPolygon(int xArray[], int yArray[]){
		
//		super.xpoints = xArray;
//		super.ypoints = yArray;
		
		
		for(int i = 0; i<xArray.length; i++){
			super.xpoints[i] = xArray[i];
			super.ypoints[i] = yArray[i];
		}
	}

}
