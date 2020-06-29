import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class BookService {
  
  _baseURL: string = "api/Books";

  constructor(private http:HttpClient) { }

  getAllBooks() {
    console.log("getting all books")
    return this.http.get<Book[]>(this._baseURL+"/GetBooks");
  }

}
