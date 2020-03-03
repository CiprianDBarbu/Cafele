import { Component, OnInit, Input } from '@angular/core';
import { MenuListService } from '../menu-list.service';
import { Syroup } from '../syroup';
import { SyroupSelectedService } from '../syroup-selected.service';
import { core } from '@angular/compiler';
import { Coffee } from '../coffee';
import { CoffeeSelectedService } from '../coffee-selected.service';
import { typeWithParameters } from '@angular/compiler/src/render3/util';

@Component({
  selector: 'app-syroups',
  templateUrl: './syroups.component.html',
  styleUrls: ['./syroups.component.css']
})
export class SyroupsComponent implements OnInit {

  MySyroups: Syroup[];
  @Input()
  parentCoffee:Coffee;

  constructor(private serv: MenuListService,private cs :SyroupSelectedService, private cf:CoffeeSelectedService) { }

  ngOnInit() {
    //window.alert('cof '+ JSON.stringify(this.parentCoffee));
    this.serv.getSyroup().subscribe(
      v=> {
        this.MySyroups = v;
        
        for (let index = 0; index < this.MySyroups.length; index++) {
          const element = this.MySyroups[index];
          element.isChecked = false;
          element.father = this.parentCoffee;
        }

      let defa : Syroup;
      defa=new Syroup();
      defa.father = this.parentCoffee;
      //window.alert("ba tata");
      defa.flavour = -1;
      defa.isChecked = true;
      defa.name = Syroup.noNameSyroup;
      defa.price = 0;
      
      

      this.MySyroups.push(defa);
      //window.alert(defa);
      //window.alert("ba tata");
      }
    );


    this.cf.deselectedCoffee$.subscribe( cr  =>
      {
        if(cr != this.parentCoffee)
          return;
          for(let sy of this.MySyroups){
            sy.isChecked=false;
          }
          // for (let index = 0; index < this.MySyroups.length; index++) 
          // {
          //   const element = this.MySyroups[index];
          //   element.isChecked = false;
          // }

      });
  }

  checkValue(b:boolean, c:Syroup){
    //window.alert(JSON.stringify(c));
    this.cs.SyroupWasDeselected(c);
    
    if(b){
    c.father.isChecked = true;
    this.cs.SyroupWasSelected(c);
    }
}

}
