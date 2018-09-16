import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from './models/book';
import { Author } from './models/author';

@Injectable({
  providedIn: 'root'
})
export  class  APIService {
  

  public book : Book;

  API_URL  =  '../api/';
  
  constructor(private  httpClient:  HttpClient) {}
  
   
  listBooks(){
    return  this.httpClient.get(`${this.API_URL}book/list`);
  }

  addBook(book: Book){
    return this.httpClient.post(`${this.API_URL}book/add`, book);
  }

  deleteBook(book: Book) {
    return this.httpClient.post(`${this.API_URL}book/remove`, book);
  }

  editBook(book: Book) {
    return this.httpClient.post(`${this.API_URL}book/edit`, book);
  }



  listAuthors() : any {
    return this.httpClient.get(`${this.API_URL}author/list`);
  }

  addAuthor(author: Author) {
    return this.httpClient.post(`${this.API_URL}author/add`, author);
  }
}