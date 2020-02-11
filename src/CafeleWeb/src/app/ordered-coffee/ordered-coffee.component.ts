import { Component, OnInit } from '@angular/core';
import { CoffeeSelectedService } from '../coffee-selected.service';
import { Order } from '../order';
import { OrderedCoffee } from '../OrderedCoffee';
import { SyroupSelectedService } from '../syroup-selected.service';

@Component({
  selector: 'app-ordered-coffee',
  templateUrl: './ordered-coffee.component.html',
  styleUrls: ['./ordered-coffee.component.css']
})
export class OrderedCoffeeComponent implements OnInit {

  o: Order = new Order();

  constructor(private cs :CoffeeSelectedService, private ss:SyroupSelectedService) { }

  ngOnInit() {
      this.cs.selectCoffee$.subscribe(

        cf=>{
          let oc = new OrderedCoffee();
          oc.coffee = cf;
          oc.nrCoffees =parseInt( cf.selectedOption.toString(),10);
          //window.alert("before push");
          this.o.CoffeList.push(oc);
          //incercare de sortare
          this.o.CoffeList.sort((n1,n2) => {
            if (n1.coffee.name > n2.coffee.name) {
                return 1;
            }
        
            if (n1.coffee.name < n2.coffee.name) {
                return -1;
            }
        
            return 0;
        });

          //window.alert(this.o.CoffeList.length);
          //this.o.TotalPrice += oc.coffee.price;
        }
      );

      this.ss.selectSyroup$.subscribe(
        cs=>{
         
          for(let ol of this.o.CoffeList)
          {
            
            if(ol.coffee == cs.father){
             //window.alert("merge");
              ol.syroup = cs;
            }
          }
        }
      );

      this.cs.deselectedCoffee$.subscribe(
        cf=>{
         // window.alert("deselect coffee "+ JSON.stringify(cf));
            let position:number = -1;
            for(let i=0; i<this.o.CoffeList.length;i++)
            {
                var element = this.o.CoffeList[i].coffee;
                if(element == cf) position = i;
            }
            //window.alert("Now remove "+position);
            if(position>-1)
                this.o.CoffeList.splice(position,1);
        }
      )

      this.ss.deselectedSyroup$.subscribe(
        cs=>{
          for(let ol of this.o.CoffeList)
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
