import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";
import { APIService } from  '../api.service';
import { Book } from '../models/book';
import { Author } from '../models/author';


@Component({
  selector: 'app-add-author',
  templateUrl: './add-author.component.html',
  styleUrls: ['./add-author.component.css']
})
export class AddAuthorComponent implements OnInit {

  constructor(private formBuilder:FormBuilder, private router: Router, private  apiService:  APIService) { }

  addForm: FormGroup;
  submitted = false;

  ngOnInit() {
    this.addForm = this.formBuilder.group({
      name:['', Validators.required],
      age: ['', Validators.required]
    });
  }

  get f() { return this.addForm.controls; }

  onSubmit(){
    this.submitted = true;
 
    if (this.addForm.invalid) {
        return;
    }

    let author:Author = new Author(
      0,
      this.addForm.value.name,
      this.addForm.value.age,
      null
    );

    this.apiService.addAuthor(author)
    .subscribe( data => {
      this.router.navigate(['list-book']);
    });
  }

  return(){
    this.router.navigate(['list-book']);
  }
  
}
  
