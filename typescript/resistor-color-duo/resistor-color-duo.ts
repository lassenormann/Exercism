export type color =
  | "black"
  | "brown"
  | "red"
  | "orange"
  | "yellow"
  | "green"
  | "blue"
  | "violet"
  | "grey"
  | "white";

export class ResistorColor {
  private colors: color[];

  constructor(colors: color[]) {
    if (colors.length < 2) {
      throw Error("At least two colors need to be present");
    }
    this.colors = colors;
  }

  value = (): number => {
    const [digit1, digit2] = this.colors;
    return this.getValue(digit1) * 10 + this.getValue(digit2);
  };

  private getValue(color: color): number {
    switch (color) {
      case "black":
        return 0;
      case "brown":
        return 1;
      case "red":
        return 2;
      case "orange":
        return 3;
      case "yellow":
        return 4;
      case "green":
        return 5;
      case "blue":
        return 6;
      case "violet":
        return 7;
      case "grey":
        return 8;
      case "white":
        return 9;
    }
  }
}

// Black: 0
// Brown: 1
// Red: 2
// Orange: 3
// Yellow: 4
// Green: 5
// Blue: 6
// Violet: 7
// Grey: 8
// White: 9
