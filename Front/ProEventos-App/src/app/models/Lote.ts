import { Evento } from "./Evento";

export interface Lotes {
  id: number;
  nome: string;
  preço: number;
  dataInicio?: Date;
  dataFim?: Date;
  quantidade: number;
  eventoId: number;
  evento: Evento;
}
