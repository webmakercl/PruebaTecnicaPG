import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatoTelefono',
  standalone: false
})
export class FormatoTelefonoPipe implements PipeTransform {
  transform(value: string): string {

    // Se espera que el valor sea "56912345678"
    if (value === null || value === undefined) {
      throw new Error('El valor no puede ser null o undefined');
    }

    // Se formatea a "+569 1234 5678"
    return value.replace(/(\d{3})(\d{4})(\d{4})/, '+$1 $2 $3');
  }
}
