import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;


public class MyKeyListener extends KeyAdapter {
	Game game;
	
	public MyKeyListener(Game game){
		this.game = game;
	}
	
	public void keyPressed(KeyEvent ke) {

		switch (ke.getKeyCode()) {

		case KeyEvent.VK_DOWN:
			game.down = true;
			break;
		case KeyEvent.VK_UP:
			game.up = true;
			break;
		case KeyEvent.VK_LEFT:
			game.left = true;
			break;
		case KeyEvent.VK_RIGHT:
			game.right = true;
			break;

		}
		game.update();
	}

	@Override
	public void keyReleased(KeyEvent ke) {

		switch (ke.getKeyCode()) {

		case KeyEvent.VK_DOWN:
			game.down = false;
			break;
		case KeyEvent.VK_UP:
			game.up = false;
			break;
		case KeyEvent.VK_LEFT:
			game.left = false;
			break;
		case KeyEvent.VK_RIGHT:
			game.right = false;
			break;
		case KeyEvent.VK_SPACE:
			game.laser = true;
			game.laserArray[game.arrayIndex] = new Laser(game, game.x, game.y, true);
			game.t2 = new Thread(game.laserArray[game.arrayIndex]);
			game.t2.start();

			game.arrayIndex++;

			if (game.loopIndex != 19) {
				game.loopIndex = Math.min(19, ++game.loopIndex);
			}

			if (game.arrayIndex >= 19) {
				game.arrayIndex = 0;
			}

			break;
		}
		game.update();
	}
	
	
	
	
	
}
