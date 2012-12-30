
public class Laser implements Runnable {

	private final Game game;
	int x;
	int y;
	boolean alive;

	public Laser(Game game, int x, int y, boolean alive) {
		this.game = game;
		this.x = x;
		this.y = y;
		this.alive = alive;
	}

	public void run() {

		while (y > 0) {
			//System.out.println("IMA FIRIN MA LAZAR");
			game.repaint();
			try {
				Thread.sleep(40);

			} catch (InterruptedException e) {
				System.out.println("Laser Thread interrupted.");
			}

			// Speed of the lasers.
			y -= 10;
		}

		// Make it so laser does not linger on screen after reaching top of
		// window.
		alive = false;

	}

}
