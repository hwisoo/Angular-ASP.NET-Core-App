import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service';
import { FormsModule, FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-book',
  templateUrl: './new-book.component.html',
  styleUrls: ['./new-book.component.css']
})
export class NewBookComponent implements OnInit {
  
  addBookForm: FormGroup;

  constructor(private service: BookService, private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
    this.addBookForm = this.fb.group({
      id:[Math.floor(Math.random() * 1000)],
      title: [null, Validators.required],
      author: [null, Validators.required],
      description: [null, Validators.compose([Validators.required, Validators.minLength(30)])],
      rating: [null],
      dateStart: [null],
      dateRead:[null]
    })
  }

  onSubmit() {
    this.service.addBook(this.addBookForm.value).subscribe(data => {
      console.log("Submitted...");
      this.router.navigate(["/books"]);
    })
  }

}
