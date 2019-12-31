import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Coffee } from './coffee';
import { Observable } from 'rxjs';
import { Syroup } from './syroup';

@Injectable({
  providedIn: 'root'
})
export class MenuListService {

    apiurl: string = "http://localhost:54308/api/Coffee/";

    constructor(private http: HttpClient) { }

    public getCofee() :Observable<Coffee[]> {
        return this.http.get<Coffee[]>(this.apiurl +"allcofees");
    }

    public getSyroup() :Observable<Syroup[]> {
      return this.http.get<Syroup[]>(this.apiurl +"allsyroups");
  }

}
