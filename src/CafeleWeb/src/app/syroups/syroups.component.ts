import { Component, OnInit, Input } from '@angular/core';
import { MenuListService } from '../menu-list.service';
import { Syroup } from '../syroup';
import { SyroupSelectedService } from '../syroup-selected.service';
import { core } from '@angular/compiler';
import { Coffee } from '../coffee';

@Component({
  selector: 'app-syroups',
  templateUrl: './syroups.component.html',
  styleUrls: ['./syroups.component.css']
})
export class SyroupsComponent implements OnInit {

  MySyroups: Syroup[];
  @Input()
  parentCoffee:Coffee;

  constructor(private serv: MenuListService,private cs :SyroupSelectedService) { }

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
      }
    );
  }

  checkValue(b:boolean, c:Syroup){
    window.alert(JSON.stringify(c));
    if(b){
     
    this.cs.SyroupWasSelected(c);
    }
    else{
     this.cs.SyroupWasDeselected(c);
    }
}

}
