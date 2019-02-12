import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostBstService {
  private url = 'http://localhost:5000/solid/binarySearchTree';

  constructor(private http: HttpClient) { }

  postBst(body: string): Observable<any> {
    return this.http.post(this.url, body);
  }
}
