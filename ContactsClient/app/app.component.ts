import { Component } from '@angular/core';
import { ContactService } from "./contacts/contact.service";


@Component({
    selector: 'pm-app',
    template: `
        <div><h1>{{pageTitle}}</h1>
<pm-contacts></pm-contacts>
</div>
    `,
    providers:[ContactService]
})
export class AppComponent {
    pageTitle: string=`Contacts Client`;
}
