// Check this solution, very elegant; https://exercism.io/tracks/typescript/exercises/rna-transcription/solutions/a3d6bd093afc4b2096a5e5d619aa154e
export type nucleotide = "G" | "C" | "T" | "A";

const nucleotideComplements: Record<nucleotide, string> = {
  G: "C",
  C: "G",
  T: "A",
  A: "U",
};

class Transcriptor {
  toRna = (dnaStrand: string): string =>
    [...dnaStrand]
      .map((n) => nucleotideComplements[n as nucleotide] || this.error())
      .join("");

  error = (): never => {
    throw Error("Invalid input DNA.");
  };
}

export default Transcriptor;
