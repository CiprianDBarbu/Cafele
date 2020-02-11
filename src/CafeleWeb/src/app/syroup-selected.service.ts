import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import {Syroup} from './syroup';

@Injectable({
  providedIn: 'root'
})
export class SyroupSelectedService {

  private selectSyroup = new Subject<Syroup>();
  selectSyroup$ = this.selectSyroup.asObservable();

  private deselectedSyroup = new Subject<Syroup>();
  deselectedSyroup$ = this.deselectedSyroup.asObservable();

  constructor() { }

  SyroupWasSelected(c:Syroup){
    
    this.selectSyroup.next(c);
  }

  SyroupWasDeselected(c:Syroup)
  {
    this.deselectedSyroup.next(c);
  }



}
