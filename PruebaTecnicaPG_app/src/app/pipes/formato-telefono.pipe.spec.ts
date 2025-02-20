import { FormatoTelefonoPipe } from './formato-telefono.pipe';

describe('FormatoTelefonoPipe', () => {
  const pipe = new FormatoTelefonoPipe();

  it('deberia formatear "56912345678" a "+569 1234 5678"', () => {
    expect(pipe.transform('56912345678')).toBe('+569 1234 5678');
  });

  it('deberia lanzar un error si se pasa null', () => {
    expect(() => pipe.transform(null as any)).toThrowError('El valor no puede ser null o undefined');
  });
});
