import { Author } from "./author";

export class Book{
    constructor(
        public BookId: number,
        public Name: string,
        public AuthorId: number,
        public Author: Author,
        public Price?: number,
        public Quantity?: number,
    ){}
}