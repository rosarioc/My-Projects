import java.applet.Applet;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Polygon;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.Random;

public class Game extends Applet implements Runnable {

	// things to do next: create asteroids(polygons) to shoot down, make it so
	// spaceship cannot go offscreen, Make custom polygon class.

	// Testing
	int tempX;
	int tempY;
	// keep
	int polyx[] = { 50, 50, 150, 150 };
	int polyy[] = { 100, 150, 200, 80 };
	int resetPolyx[] = { 50, 50, 150, 150 };
	int resetPolyy[] = { 100, 150, 200, 80 };
	int npoly = 4;
	// keep

	// keep
	int polyx2[] = { 200, 180, 240, 280, 270 };
	int polyy2[] = { 250, 360, 400, 320, 260 };
	int npoly2 = 5;
	// keep

	// Polygon poly = new Polygon(polyx, polyy, npoly);
	CustomPolygon poly = new CustomPolygon(polyx, polyy, npoly);
	Polygon poly2 = new Polygon(polyx2, polyy2, npoly2);

	// Working
	Stars starArray[] = new Stars[60]; // number of stars in the background.
	Laser laserArray[] = new Laser[20];// maybe make this into arrayList.
	int arrayIndex;
	int loopIndex;

	// Random object
	Random rand = new Random();

	// How many pixels the square moves per unit of movement.
	private static final int SPEED = 5;

	// flags that are set when keypressed/keyreleased events occur.
	boolean up, down, left, right, laser;
	boolean paintStars, temp;

	// vX & vY are the speed of the x and y direction of the square. x and y are
	// the position of the square.
	public int vX, vY, x, y;

	// Declare a thread.
	Thread t, t2;

	// Do one time:
	public void init() {

		setSize(600, 600);
		setBackground(Color.BLACK);
		arrayIndex = 0;
		loopIndex = 0;
		paintStars = true;
		temp = true;

		// Initialize the stars
		for (int i = 0; i < starArray.length; i++) {
			starArray[i] = new Stars(rand.nextInt(599), rand.nextInt(599), 1, 1);
		}

		// Initial position of the spaceship
		x = 300;
		y = 588;

		// Initialize and start main thread.
		t = new Thread(this);
		t.start();

		// add the key listener
		// addKeyListener(this);
		addKeyListener(new MyKeyListener(this));
	}

	public void run() {

		while (true) {
			//moveAsteroids(poly, resetPolyx, resetPolyy);
			go();
			try {
				Thread.sleep(20);
				repaint();
			} catch (InterruptedException e) {
				System.out.println("Main thread interrupted");
			}
		}

	}

	// Called in the main thread, simply updates the x and y values.
	public void go() {
		x += vX;
		y += vY;
	}

	// Control
	public void moveAsteroids(CustomPolygon poly, int polyx[], int polyy[]) {

		// set the speeds of the asteroids once.
		if (temp) {
			tempX = rand.nextInt(4) + 1;
			tempY = rand.nextInt(4) + 1;
			temp = false;
		}

		
		if(poly.intersects(0, 800, 600, 2)){
			//System.out.println("Polygon intersected");
			
			resetAsteroids(poly, polyx, polyy);
		}
//		for(int i = 0; i<4; i++){
//				System.out.println(poly.xpoints[i]);
//			}
		poly.translate(0, 5);
		System.out.println("moveAsteroids has been called");
		//poly2.translate(0, 1);

	}

	public void resetAsteroids(CustomPolygon poly, int xpoints[], int ypoints[]) {

		poly.resetPolygon(xpoints, ypoints);

	}

	// Makes respective x and y velocities positive/negative depending on
	// keystroke.
	public void update() {
		vX = 0;
		vY = 0;

		if (down)
			vY = SPEED;
		if (up)
			vY = -SPEED;
		if (left)
			vX = -SPEED;
		if (right)
			vX = SPEED;
	}

	// public void killWeapon(boolean weapon) {
	//
	// if (!weapon) {
	// laser = false;
	// System.out.println("kill weapon");
	// }
	// }

	public void paint(Graphics g) {
		g.setColor(Color.WHITE);

		// Draw the stars
		if (paintStars) {
			for (int i = 0; i < starArray.length; i++) {
				g.drawRect(starArray[i].x, starArray[i].y, 1, 1);
			}
		}

		g.drawPolygon(poly);
		//g.drawPolygon(poly2);
		g.fillRect(x, y, 10, 10);

		if (laser) {

			for (int i = 0; i < loopIndex; i++) {
				if (laserArray[i].alive) {
					g.setColor(Color.PINK);
					g.drawLine(laserArray[i].x + 5, laserArray[i].y - 5,
							laserArray[i].x + 5, laserArray[i].y + 10);
				}
			}

		}
	}
}