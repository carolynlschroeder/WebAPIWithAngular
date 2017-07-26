import { PipeTransform, Pipe } from '@angular/core';
import { IContact } from './contact';

@Pipe({
    name: 'contactFilter'
})
export class ContactFilterPipe implements PipeTransform {

    transform(value: IContact[], filterBy: string): IContact[] {

        filterBy = filterBy ? filterBy.toLocaleLowerCase() : null;
        return filterBy ? value.filter((contact: IContact) =>
            contact.name.toLocaleLowerCase().indexOf(filterBy) !== -1) : value;

    }
}
