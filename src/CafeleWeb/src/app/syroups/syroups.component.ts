import { Component, OnInit } from '@angular/core';
import { MenuListService } from '../menu-list.service';
import { Syroup } from '../syroup';

@Component({
  selector: 'app-syroups',
  templateUrl: './syroups.component.html',
  styleUrls: ['./syroups.component.css']
})
export class SyroupsComponent implements OnInit {

  MySyroups: Syroup[];

  constructor(private serv: MenuListService) { }

  ngOnInit() {
    this.serv.getSyroup().subscribe(
      v=> {
        this.MySyroups = v;
      }
    );
  }

}
