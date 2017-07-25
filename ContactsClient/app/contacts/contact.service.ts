import { Injectable } from '@angular/core';

import { IContact } from './contact';


@Injectable()
export class ContactService {
    getContacts():IContact[] {
        return[
            {
                "contactId": "1ca62d26-9a0a-4c05-aa89-0e936da6667a",
                "name": "Carol Mason",
                "address": "123 Test St",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66202"
            },
            {
                "contactId": "48f35979-7559-4e9b-b6e6-11edfbb5d505",
                "name": "Amy Montoni",
                "address": "234 MyStreet",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66207"
            },
            {
                "contactId": "3dfadcc9-4eb7-492b-ae1f-1f6c8be10845",
                "name": "Robert Morris",
                "address": "123 Way",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66207"
            },
            {
                "contactId": "73a327e9-f74c-4053-9f00-3db04bacbf39",
                "name": "Richard Thurmond",
                "address": "123 Example St",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66202"
            },
            {
                "contactId": "8541e375-8cfa-4f00-99f6-6dd431eb71fb",
                "name": "Val Fox",
                "address": "123 My Street",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66207"
            },
            {
                "contactId": "2a0799e6-c877-450c-b92d-75e8703197e1",
                "name": "Fred Smith",
                "address": "123 Third St",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66207"
            },
            {
                "contactId": "5746402c-83e9-4fd5-b680-90509db17d79",
                "name": "Michelle Williams",
                "address": "110 Example St",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66202"
            },
            {
                "contactId": "7e928082-2f11-4235-a65a-a1daee054fc6",
                "name": "Herbert White",
                "address": "123 Second",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66207"
            },
            {
                "contactId": "0cadc16c-fbfa-46b3-a024-ee3ae34d2687",
                "name": "Rick Thames",
                "address": "234 First",
                "city": "Overland Park",
                "state": "KS",
                "zip": "66202"
            }
        ];
    }
}


