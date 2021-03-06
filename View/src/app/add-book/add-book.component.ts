import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";
import { APIService } from  '../api.service';
import { Book } from '../models/book';
import { Author } from '../models/author';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  constructor(private formBuilder:FormBuilder, private router: Router, private  apiService:  APIService) { 

  }

  submitted = false;
  book:  Book;
  authors: Author[];
  addForm: FormGroup;

  ngOnInit() {
    this.authors = this.apiService.listAuthors().subscribe((data:  Array<Author>) => {
      this.authors  =  data;
  });

    this.addForm = this.formBuilder.group({
      name:['', Validators.required],
      price: [],
      quantity: [],
      author: ['', Validators.required]
    });
  }

  
  get f() { return this.addForm.controls; }

  onSubmit(){
    this.submitted = true;
 
    if (this.addForm.invalid) {
        return;
    }

    let book:Book = new Book(
      0,
      this.addForm.value.name,
      this.addForm.value.author,
      null,
      this.addForm.value.price,
      this.addForm.value.quantity
    );

    this.apiService.addBook(book)
    .subscribe( data => {
      this.router.navigate(['list-book']);
    });
  }

  return(){
    this.router.navigate(['list-book']);
  }
  
}
  
