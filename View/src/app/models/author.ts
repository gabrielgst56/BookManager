import { Book } from "./book";


export class Author{
    constructor(
        public AuthorId: number,
        public Name: string,
        public Age: number,
        public Books: Book[],
    ){}


}