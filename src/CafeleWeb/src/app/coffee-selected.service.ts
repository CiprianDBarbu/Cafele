import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Coffee } from './coffee';

@Injectable({
  providedIn: 'root'
})
export class CoffeeSelectedService {

  private selectCoffee = new Subject<Coffee>();
  selectCoffee$ = this.selectCoffee.asObservable();

  private deselectedCoffee = new Subject<Coffee>();
  deselectedCoffee$ = this.deselectedCoffee.asObservable();

  constructor() { }

  CoffeeWasSelected(c:Coffee){
    this.selectCoffee.next(c);
  }

  CoffeeWasDeselected(c:Coffee)
  {
    this.deselectedCoffee.next(c);
  }




}
