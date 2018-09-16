import { Component, OnInit } from '@angular/core';
import{ APIService } from './../api.service'
import { Book } from '../models/book';
import { FormGroup, FormBuilder, Validators } from '../../../node_modules/@angular/forms';
import { Router } from '../../../node_modules/@angular/router';
import { callLifecycleHooksChildrenFirst } from '../../../node_modules/@angular/core/src/view/provider';
import { NgbModal } from '../../../node_modules/@ng-bootstrap/ng-bootstrap';
import { NgbdModalBasic } from '../modal/modal.component';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {

  
  submitted = false;
  book:  Book;
  editForm: FormGroup;
  modal : NgbdModalBasic;


  constructor(
    private formBuilder:FormBuilder,
    private router: Router,
    private  apiService:  APIService
  ) { }

  ngOnInit() { 

    this.editForm = this.formBuilder.group({
      name:['', Validators.required],
      price: [],
      quantity: []
    });

    this.book = this.apiService.book;

    this.editForm.setValue({
      name : this.book.Name,
      price : this.book.Price,
      quantity : this.book.Quantity
    });

    
  }

  onSubmit(){
    this.submitted = true;
 
    if (this.editForm.invalid) {
        return;
    }

    this.book.Name = this.editForm.value.name;
    this.book.Price = this.editForm.value.price;
    this.book.Quantity = this.editForm.value.quantity;


    this.apiService.editBook(this.book)
    .subscribe(
      data => {
        this.router.navigate(['list-book']);
      },
      error =>{
        alert(error);
      });
    
  }

  return(){
    this.router.navigate(['list-book']);
  }
}
