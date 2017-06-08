package Game.Pacman;

import java.awt.Color;
import java.awt.Graphics2D;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;

import javax.imageio.ImageIO;

import org.game.engine.Game;
import org.game.engine.GameApplication;

public class PackMan extends Game {
	public static void main(String[] args) {
		GameApplication.start(new PackMan());
	}
	
	BufferedImage packman;
	final int STEP = 2;
	int curDir, reqDir;
	int frame;
	// BAIGIAU KADPERVADINTI X IR Y I COLUMN IR ROW
	int column, row;
	int columns, rows;
	ArrayList<String> lines = new ArrayList<String>();
	BufferedImage[] mazeImages = new BufferedImage[4];
	int mazeNO = 0;
	Maze[] mazes = new Maze[4];
	char[][] cells; // COPY OF CHARS IN CURRENT MAZE

	public PackMan() {
		// load mazes information
		for (int m = 0; m < 4; m++) {
			mazes[m] = new Maze(m);
		}

		// GET COPY OF CELLS
		cells = mazes[mazeNO].getCells();

		// update the information of mazes[mazeNO]
		rows = mazes[mazeNO].rows;
		columns = mazes[mazeNO].columns;

		// update position for packman
		row = mazes[mazeNO].row;
		column = mazes[mazeNO].column;

		// size of game screen
		width = mazes[mazeNO].width;
		height = mazes[mazeNO].height;

		title = "PacMan";
		frame = 0;
		curDir = reqDir = KeyEvent.VK_RIGHT;
		// width = height = 400;
		try {
			packman = ImageIO.read(new File("images/packman.png"));
			for (int m = 0; m < 4; m++) {
				mazeImages[m] = ImageIO.read(new File("images/" + m + m + ".png"));

			}
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

	@Override
	public void keyPressed(KeyEvent e) {
		int key = e.getKeyCode();
		if (37 <= key && key <= 40) {
			reqDir = key;
		}
		// super.keyPressed(e);
	}

	@Override
	public void update() {
		frame++;
		if (frame > 8) {
			frame = 0;
		}
		// PADAROME KAD PACMANAS NEGALETU EITI I SIENA.
		// LAIKA
		if (move(reqDir) == SUCCESS) {
			curDir = reqDir;
		} else {
			move(curDir);
		}

		if (cells[row][column] == '2') {
			// eat a pill
			cells[row][column] = '1';
		} else if (cells[row][column] == '3') {
			// eat a power pill
			cells[row][column] = '1';
			delay=15;
		}

	}

	// Sukuriamas naujas konstruktorius kuriuo tikrinsime ar PacMan turi kelia
	// kur eiti (t.y. '1'),jei ne tai jis laikosi nurodytos krypties iki pat '1'

	static int SUCCESS = 1, FAIL = 0;

	private int move(int reqDir) {
		// PACMAN POZICIJA. NUSTATOMA SU ROW AND COLUMN
		switch (reqDir) {
		case KeyEvent.VK_LEFT: // 37
			if (column > 0 && mazes[mazeNO].charAt(row, column - 1) != '0') {
				column -= 1;
				return SUCCESS;
			}
			break;
		case KeyEvent.VK_UP: // 38
			if (row > 0 && mazes[mazeNO].charAt(row - 1, column) != '0') {
				row -= 1;
				return SUCCESS;
			}
			break;
		case KeyEvent.VK_RIGHT: // 39
			if (column < columns - 1 && mazes[mazeNO].charAt(row, column + 1) != '0') {
				column += 1;
				return SUCCESS;
			}
			break;
		case KeyEvent.VK_DOWN: // 40
			if (row < rows - 1 && mazes[mazeNO].charAt(row + 1, column) != '0') {
				row += 1;
				return SUCCESS;
			}
			break;

		}
		return FAIL;
	}

	// // Apriboti judejimo erdve
	// if (column < 0) {
	// column = 0;
	// } else if (column > width - 42 - STEP) {
	// column = width - 42 - STEP;
	// }
	//
	// if (row < 0) {
	// row = 0;
	// } else if (row > height - 65 - STEP) {
	// row = height - 65 - STEP;
	// }

	@Override
	public void draw(Graphics2D g) {
		g.drawImage(mazeImages[mazeNO], 0, 0, null);
		g.setColor(Color.white);
		for (int r = 0; r < mazes[mazeNO].rows; r++) {
			for (int c = 0; c < mazes[mazeNO].columns; c++) {
				if (cells[r][c] == '2') {
					// in 2 draw a pill
					g.fillOval(c * STEP - 3, r * STEP - 3, 6, 6);
				} else if (cells [r][c] == '3') {
					// in 3 draw power pill
					g.fillOval(c * STEP - 6, r * STEP - 6, 12, 12);
				}
			}
		}
		g.drawImage(packman.getSubimage((frame / 3) * 30, (curDir - 37) * 30, 28, 28), column * STEP - 14,
				row * STEP - 14, null);

	}

}
