import { Component, OnInit } from '@angular/core';
import { CoffeeSelectedService } from '../coffee-selected.service';
import { Order } from '../order';
import { OrderedCoffee } from '../OrderedCoffee';
import { SyroupSelectedService } from '../syroup-selected.service';
import { Coffee } from '../coffee';
import { Syroup } from '../syroup';
import { MenuListService } from '../menu-list.service';

@Component({
  selector: 'app-ordered-coffee',
  templateUrl: './ordered-coffee.component.html',
  styleUrls: ['./ordered-coffee.component.css']
})
export class OrderedCoffeeComponent implements OnInit {

 
  o: Order = new Order();

  constructor(private cs :CoffeeSelectedService, private ss:SyroupSelectedService,private ms:MenuListService) { }
 
  addCoffeeToOrderedList(cf:Coffee)
  {
    let oc = new OrderedCoffee();
    oc.coffee = cf;
    oc.nrCoffees =parseInt( cf.selectedOption.toString(),10);
    //window.alert("before push");
    this.o.coffees.push(oc);
    //incercare de sortare
    this.o.coffees.sort((n1,n2) => {
      if (n1.coffee.name > n2.coffee.name) {
          return 1;
      }
  
      if (n1.coffee.name < n2.coffee.name) {
          return -1;
      }
  
      return 0;
  });

  }

  addSyroupToORderedCoffee(cs:Syroup):boolean
  {
    let existFather:boolean = false;
          for(let ol of this.o.coffees)
          {
            
            if(ol.coffee == cs.father){
             //window.alert("merge");
             existFather = true;
              ol.syroup = cs;
            }
          }
          return existFather;
  }

  sendOrder()
  {
   
   // window.alert('sed +' + this.o.isValid());
    for(let cf of this.o.coffees)
    {
      if(cf.syroup.name == Syroup.noNameSyroup)
      cf.syroup = null;
    }
    this.ms.sendOrder(this.o).subscribe(b=>window.alert("Comanda cu succes!"+b));
  }

  ngOnInit() {
      this.cs.selectCoffee$.subscribe(

        cf=>{
          this.addCoffeeToOrderedList(cf);
          //window.alert(this.o.coffees.length);
          //this.o.TotalPrice += oc.coffee.price;
        }
      );

      this.ss.selectSyroup$.subscribe(
        cs=>{
         
          let existFather:boolean = this.addSyroupToORderedCoffee(cs);
          if(!existFather)
          {
            this.addCoffeeToOrderedList(cs.father);
            this.addSyroupToORderedCoffee(cs);
          }

          
        }
      );

      this.cs.deselectedCoffee$.subscribe(
        cf=>{
         // window.alert("deselect coffee "+ JSON.stringify(cf));
            let position:number = -1;
            for(let i=0; i<this.o.coffees.length;i++)
            {
                var element = this.o.coffees[i].coffee;
                if(element == cf) position = i;
            }
            //window.alert("Now remove "+position);
            if(position>-1)
                this.o.coffees.splice(position,1);
        }
      )

      this.ss.deselectedSyroup$.subscribe(
        cs=>{
          for(let ol of this.o.coffees)
          {
            
            if(ol.coffee == cs.father){
             //window.alert("merge");
              ol.syroup = null;
            }
          }
        }
      )

      
  }

}
