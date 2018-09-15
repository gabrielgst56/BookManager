import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";

import{ APIService } from './../api.service'
import { Book } from '../models/book';

@Component({
  selector: 'app-list-book',
  templateUrl: './list-book.component.html',
  styleUrls: ['./list-book.component.css']
})

export class ListBookComponent implements OnInit {

  private  books:  Array<object> = [];

  constructor(private router: Router, private  apiService:  APIService
  ) { }

  ngOnInit() {
     this.getBooks();
  }

  public getBooks(){
      this.apiService.listBooks().subscribe((data:  Array<Book>) => {
          this.books  =  data;
      });
  }

  public deleteBook(book: Book) : void {
    this.apiService.deleteBook(book)
      .subscribe( data => {
        this.getBooks();
      })
  }

  public editBook(book: Book) : void{
    this.apiService.book = book;
    this.router.navigate(['edit-book']);
  }


  public addBook() : void{
    this.router.navigate(['add-book']);
  }


}
