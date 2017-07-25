import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {ContactListComponent} from './contacts/contact-list.component';

@NgModule({
  imports: [ BrowserModule ],
  declarations: [ AppComponent, ContactListComponent ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
