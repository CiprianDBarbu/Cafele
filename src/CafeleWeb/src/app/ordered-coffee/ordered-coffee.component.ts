import { Component, OnInit } from '@angular/core';
import { CoffeeSelectedService } from '../coffee-selected.service';
import { Order } from '../order';
import { OrderedCoffee } from '../OrderedCoffee';

@Component({
  selector: 'app-ordered-coffee',
  templateUrl: './ordered-coffee.component.html',
  styleUrls: ['./ordered-coffee.component.css']
})
export class OrderedCoffeeComponent implements OnInit {

  o: Order = new Order();

  constructor(private cs :CoffeeSelectedService) { }

  ngOnInit() {
      this.cs.selectCoffee$.subscribe(

        cf=>{
          let oc = new OrderedCoffee();
          oc.coffee = cf;
          this.o.CoffeList.push(oc);
          window.alert(this.o.CoffeList.length);
          //this.o.TotalPrice += oc.coffee.price;
        }
      );

      this.cs.deselectedCoffee$.subscribe(
        cf=>{
            let position:number = -1;
            for(let i=0; i<this.o.CoffeList.length;i++)
            {
                var element = this.o.CoffeList[i].coffee;
                if(element == cf) position = i;
            }
            //window.alert("Now remove "+position);
          this.o.CoffeList.splice(position,1);
        }
      )
      
  }

}
