import { Component, OnInit } from '@angular/core';
import { MenuListService } from '../menu-list.service';
import { Coffee } from '../coffee';
import { CoffeeSelectedService } from '../coffee-selected.service';
import { core } from '@angular/compiler';

@Component({
  selector: 'app-coffees',
  templateUrl: './coffees.component.html',
  styleUrls: ['./coffees.component.css']
})
export class CoffeesComponent implements OnInit {

  MyCoffees: Coffee[];

  constructor(private serv: MenuListService, private cs :CoffeeSelectedService ) { }
  ngOnInit() {
    this.serv.getCofee().subscribe(
      v=> {
        window.alert("Ciprian" + v.length);
        this.MyCoffees = v;
      }
    );
    
    
  }
  checkValue(b:boolean, c:Coffee){
      //window.alert(JSON.stringify(b));
      if(b){
      this.cs.CoffeeWasSelected(c);
      }
      else{
       this.cs.CoffeeWasDeselected(c);
      }
  }
  
  
}


