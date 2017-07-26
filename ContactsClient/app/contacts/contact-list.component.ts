import { Component, OnInit } from '@angular/core';

import { IContact } from './contact';
import { ContactService } from './contact.service';


@Component({
    selector: "pm-contacts",
    templateUrl: 'app/contacts/contact-list.component.html'
})
export class ContactListComponent implements OnInit {

    contacts: IContact[];
    listFilter: string;

    constructor(private contactService: ContactService) { }

    ngOnInit(): void {
        this.contacts = this.contactService.getContacts();

    }
}