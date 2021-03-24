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

const colorValues: Record<color, number> = {
  black: 0,
  brown: 1,
  red: 2,
  orange: 3,
  yellow: 4,
  green: 5,
  blue: 6,
  violet: 7,
  grey: 8,
  white: 9,
};

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
    return colorValues[digit1] * 10 + colorValues[digit2];
  };
}
