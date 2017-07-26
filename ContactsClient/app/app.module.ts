import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { ContactListComponent } from './contacts/contact-list.component';
import { ContactFilterPipe } from './contacts/contact-filter.pipe';

@NgModule({
  imports: [ BrowserModule, HttpModule, FormsModule],
  declarations: [ AppComponent, ContactListComponent, ContactFilterPipe ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
