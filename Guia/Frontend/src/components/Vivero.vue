<template>
<v-layout align-start>
    <v-flex>
        <v-toolbar flat color="white">
            <v-toolbar-title>Cartera de Facturas</v-toolbar-title>
            <v-divider class="mx-2" inset vertical></v-divider>
            <v-spacer></v-spacer>

            <v-divider class="mx-2" inset vertical></v-divider>
            <v-spacer></v-spacer>
            <v-btn v-if="mostrarPlantas==0" @click="mostrarNuevo" color="primary" dark class="mb-2">Nuevo</v-btn>

            <v-dialog v-model="mostrarFrmPlanta" max-width="1000px">
                <v-card>
                    <v-card-title>
                        <span class="headline">Seleccione una factura</span>
                    </v-card-title>
                    <v-card-text>
                        <v-container grid-list-md>
                            <v-layout wrap>
                                <v-flex xs12 sm12 md12 lg12 xl12>
                                    <template>
                                        <v-data-table :headers="headersPlanta" :items="planta" class="elevation-1">
                                            <template slot="items" slot-scope="props">
                                                <td class="justify-center layout px-0">
                                                    <v-icon small class="mr-2" @click="agregarPlantaVivero(props.item)">
                                                        add
                                                    </v-icon>
                                                </td>
                                                  <td>{{ props.item.id }}</td>
                                                 <td>{{ props.item.nroFactura }}</td>
                                            
                                                     
                                                 <td>{{ props.item.totalFacturado }}</td>
                                            <td>{{ props.item.retencion }}</td>
                                            </template>
                                            <template slot="no-data">
                                                <h3>No hay facturas para mostrar.</h3>
                                            </template>
                                        </v-data-table>
                                    </template>
                                </v-flex>
                            </v-layout>
                        </v-container>
                    </v-card-text>
                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn @click="mostrarNuevo()" color="blue darken" flat>
                            Aceptar
                        </v-btn>
                        <v-btn @click="mostrarNuevo()" color="blue darken" flat>
                            Cancelar
                        </v-btn>
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </v-toolbar>


        <v-data-table :headers="headers" :items="vivero" class="elevation-1" v-if="mostrarPlantas==0">

            <template slot="items" slot-scope="props">
                <td>{{ props.item.id }}</td>
                <td>{{ props.item.nombre }}</td>
                <td>{{ props.item.tsEfectiva }}</td>
                <td>{{ props.item.costoInicial }}</td>
                <td>{{ props.item.costoFinal }}</td>
                <td>{{ props.item.valorNeto }}</td>
                <td>{{ props.item.valorRecaudado }}</td>
                <td>{{ props.item.valorEntero }}</td>
                <td>{{ props.item.tcea }}</td>
                

                <td class="justify-center">
                    <v-icon small class="mr-2" @click="filtrarPlantas(props.item)">
                        add
                    </v-icon>
                </td>
            </template>
        </v-data-table>

        <v-data-table :headers="headersPlantaVivero" :items="plantaVivero" class="elevation-1" v-if="mostrarPlantas==1">

            <template slot="items" slot-scope="props">
                <td>{{ props.item.vivero.id }}</td>
                <td>{{ props.item.vivero.nombre }}</td>
                <td>{{ props.item.vivero.tsEfectiva }}</td>
                <td>{{ props.item.vivero.costoInicial }}</td>
                <td>{{ props.item.vivero.costoFinal }}</td>
                <td>{{ props.item.planta.id }}</td>
                 <td>{{ props.item.nroFactura }}</td>
          <td>{{ props.item.diaEmision }}</td>
          <td>{{ props.item.diaPago }}</td>
          <td>{{ props.item.moneda }}</td>
          <td>{{ props.item.totalFacturado }}</td>
          <td>{{ props.item.retencion }}</td>
                <td>{{ props.item.fechaRegistro }}</td>
            </template>
        </v-data-table>

        <v-btn v-if="mostrarPlantas==1" @click="ocultarPlantas" color="primary" dark class="mb-2">Regresar</v-btn>

        <v-container grid-list-sm class="pa-4 white" v-if="mostrarPlantas == 2">
            <v-layout row wrap>
                <v-flex xs12 sm4 md4 lg4 xl4>
                    <v-text-field v-model="nombreCartera" label="Nombre de la Cartera">
                    </v-text-field>
                </v-flex>

                <v-flex xs12 sm4 md4 lg4 xl4>
                    <v-text-field v-model="tsEfectiva" label="Tasa Efectiva de la Cartera">
                    </v-text-field>
                </v-flex>
                <v-flex xs12 sm4 md4 lg4 xl4>
                    <v-text-field v-model="costoInicial" label="Costos Iniciales">
                    </v-text-field>
                </v-flex>
                <v-flex xs12 sm4 md4 lg4 xl4>
                    <v-text-field v-model="costoFinal" label="Costos Finales">
                    </v-text-field>
                </v-flex>

                <v-flex xs12 sm2 md2 lg2 xl2>
                    <v-btn @click="mostrarFrmPlantas()" small fab dark color="teal">
                        <v-icon dark>list</v-icon>
                    </v-btn>
                </v-flex>

                <v-flex xs12 sm12 md12 lg12 xl12>
                    <v-data-table :headers="headersPlantaViveroFrm" :items="plantaVivero" hide-actions class="elevation-1">
                        <template slot="items" slot-scope="props">
                            <td class="justify-center layout px-0">
                                  <v-icon small class="mr-2" @click="eliminarDetalle(detalles,props.item)">
                                    delete
                                </v-icon>
                                <td>{{ props.item.plantaid }}</td>
                                <td>{{ props.item.plantanroFactura }}</td>
                                <td>{{ props.item.totalFactura }}</td>
                                <td>{{ props.item.retencion }}</td>
                        </template>
                        <template slot="no-data">
                            <h3>No hay facturas agregadas a la Cartera.</h3>
                        </template>
                    </v-data-table>
                </v-flex>

                <v-flex xs12 sm12 md12 lg12 xl12>
                    <v-btn @click="ocultarPlantas()" color="blue darken-1" flat>Cancelar</v-btn>
                    <v-btn @click="guardar()" color="success">Guardar</v-btn>
                </v-flex>
            </v-layout>
        </v-container>

    </v-flex>
</v-layout>
</template>

<script>
import axios from 'axios'

export default {
    data() {
        return {

            dialog: false,
            headers: [
                {
                    text: 'Codigo Cartera',
                    value: 'codigoCartera',
                    sortable: true
                },
                {
                    text: 'Nombre Cartera',
                    value: 'nombreCartera'
                },
                {
                    text: 'Tasa Efectiva',
                    value: 'tsEfectiva',
                },
                {
                    text: 'Costo Inicial',
                    value: 'costoInicial',
                },
                {
                    text: 'Costo Final',
                    value: 'costoFinal',
                },
                {
                    text: 'Valor Neto',
                    value: 'valorNeto',
                },
                {
                    text: 'Valor Recaudado',
                    value: 'valorRecaudado',
                },
                 {
                    text: 'Valor Entero',
                    value: 'valorEntero',
                },
                 {
                    text: 'TCEA',
                    value: 'tcea',
                },
                {
                    text: 'Seleccionar',
                    value: 'seleccionar',
                }
            ],
            headersPlantaVivero: [
              
               {

                    text: 'Codigo Cartera',
                    value: 'codigoVivero',
                    sortable: true
                },
                {
                    text: 'Nombre Cartera',
                    value: 'nombreVivero'
                },
                {
                    text: 'Tasa Efectiva',
                    value: 'paisVivero',
                },
                {
                    text: 'Codigo Factura',
                    value: 'codigoPlanta',
                },
                {
                    text: 'Nombre Factura',
                    value: 'nombrePlanta',
                },
                {
                    text: 'Fecha Registro',
                    value: 'fechaRegistro',
                }
            ],
            headersPlantaViveroFrm: [
               {
                    text: 'Delete',
                    value: 'delete',
                    sortable: true
                },
               {
                    text: 'Codigo Factura',
                    value: 'codigoPlanta',
                },
                {
                    text: 'Nro. Factura',
                    value: 'nombrePlanta',
                },
                 {
                    text: 'Total Facturado',
                    value: 'totalFacturado',
                },
                 {
                    text: 'Retencion',
                    value: 'retencion',
                },
            ],
            headersPlanta: [
                {
                    text: 'Seleccionar',
                    value: 'seleccionar',
                },
                {
                    text: 'Codigo Factura',
                    value: 'codigoPlanta',
                },
                {
                    text: 'Nro. Factura',
                    value: 'nombrePlanta',
                },
                 {
                    text: 'Total Facturado',
                    value: 'totalFacturado',
                },
                 {
                    text: 'Retencion',
                    value: 'retencion',
                },
            ],

            texto: '',

            mostrarPlantas: 0,
            mostrarFrmPlanta: 0,

            nombreVivero: '',
            paisVivero: '',

            vivero: [],
            planta: [],
            plantaVivero: [],

        }
    },

    watch: {
        dialog(val) {
            val || this.close()
        }
    },

    created() {
        this.listar();
    },

    methods: {

        listar() {
            let me = this;

            axios.get('api/viveros').then(function (response) {
                console.log(response);
                me.vivero = response.data;
            }).catch(function (error) {
                console.log(error);
            });
        },

        filtrarPlantas(data = []) {
            let me = this;
            me.mostrarPlantas = 1;

            axios.get('api/viveros/Plantas/' + data['nombre']).then(function (response) {
                //console.log(response);
                me.plantaVivero = response.data;
            }).catch(function (error) {
                console.log(error);
            });
        },

        listarPlantas() {
            let me = this;
            
            axios.get('api/plantas').then(function (response) {
                //console.log(response);
                me.planta = response.data;
            }).catch(function (error) {
                console.log(error);
            });
        },

        ocultarPlantas() {
            this.mostrarPlantas = 0;
            this.limpiar();
            this.listar();
        },

        mostrarNuevo() {
            this.mostrarPlantas = 2;
            this.mostrarFrmPlanta = 0;
        },

        mostrarFrmPlantas() {
            this.mostrarFrmPlanta = 1;
            this.listarPlantas();
        },

        agregarPlantaVivero(data = []) {
            console.log(data);
            var f = new Date();
            var dia = f.getDate();
            var mes = f.getMonth()+1;
            var anio = f.getFullYear();
            var fecha = dia+'-'+mes+'-'+anio;

            this.plantaVivero.push({
                plantaid: data['id'],
                plantanroFactura: data['nroFactura'],
                totalFactura:data['totalFacturado'],
                retencion: data['retencion']
            });

            console.log(this.plantaVivero);
        },

        guardar() {
            let me = this;

            axios
                .post("api/viveros", {
                    nombre: me.nombreCartera,
                    tsEfectiva: me.tsEfectiva,
                     costoInicial: me.costoInicial,
                      costoFinal: me.costoFinal,
                    plantas: me.plantaVivero
                })
                .then(function (response) {
                    me.ocultarPlantas();
                })
                .catch(function (error) {
                    console.log(error);
                    console.log(me.plantaVivero);
                });
        },

        limpiar()
        {
            this.texto = '',

            this.mostrarPlantas = 0,
            this.mostrarFrmPlanta= 0,

            this.nombreVivero= '',
            this.paisVivero= '',

            this.vivero= [],
            this.planta= [],
            this.plantaVivero= []
        }
    },
}
</script>
