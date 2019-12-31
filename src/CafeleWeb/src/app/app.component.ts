import { Component, OnInit } from '@angular/core';
import { MenuListService } from './menu-list.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements  OnInit {

    constructor(private serv: MenuListService) {
    }
    title = 'Cafele Web';
    ngOnInit() {
        this.serv.getCofee().subscribe(
            v => {
                window.alert("coffee number : " + v.length);
               // window.alert(JSON.stringify(v[0]));
            })

       // window.alert('done');
    }
     
}
