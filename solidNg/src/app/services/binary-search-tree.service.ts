import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BinarySearchTreeService {
  private url = 'http://localhost:5000/solid/binarySearchTree';

  constructor(private http: HttpClient) { }

  getBinarySearchTree(): Observable<any> {
    return this.http.get(this.url);
  }

}
