import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CoffeesComponent } from './coffees/coffees.component';
import { SyroupsComponent } from './syroups/syroups.component';
import { OrderedCoffeeComponent } from './ordered-coffee/ordered-coffee.component';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,
    CoffeesComponent,
    SyroupsComponent,
    OrderedCoffeeComponent
  ],
  imports: [
    BrowserModule,
      AppRoutingModule,
      FormsModule,
      HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
