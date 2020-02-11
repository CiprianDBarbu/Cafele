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
  


  options = [
    { name: "One Coffee", id: 1 },
    { name: "2 cofees", id: 2 },
    { name: "3 cofees", id: 3 },
    { name: "4 cofees", id: 4 },
    { name: "5 cofees", id: 5 }
  ]
  constructor(private serv: MenuListService, private cs :CoffeeSelectedService ) { }
  ngOnInit() {
    this.serv.getCofee().subscribe(
      v=> {
        //window.alert("Ciprian" + v.length);
        this.MyCoffees = v;
        for(let el of this.MyCoffees)
        {
          el.selectedOption = 1;
        }


      }
    );
    
    
  }
  checkValue(b:boolean, c:Coffee){
      //window.alert(JSON.stringify(b));
      this.cs.CoffeeWasDeselected(c);
      if(b){
      this.cs.CoffeeWasSelected(c);
      }
      
  }

  selectNrCoffees(nr:number,c:Coffee)
  {
    //window.alert(JSON.stringify(nr));

    this.cs.CoffeeWasDeselected(c);
    c.isChecked = true;
    this.cs.CoffeeWasSelected(c);
  }
  
  
}


