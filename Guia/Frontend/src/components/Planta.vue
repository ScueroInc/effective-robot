<template>
  <v-layout align-start>
    <v-flex>
      <v-toolbar flat color="white">
        <v-toolbar-title>Facturas</v-toolbar-title>
        <v-divider class="mx-2" inset vertical></v-divider>
        <v-spacer></v-spacer>
        <v-text-field
          class="text-xs-center"
          v-model="search"
          append-icon="search"
          label="Búsqueda"
          single-line
          hide-details
        ></v-text-field>
        <v-spacer></v-spacer>
        <v-dialog v-model="dialog" max-width="500px">
          <v-btn slot="activator" color="primary" dark class="mb-2">Nuevo</v-btn>
          <v-card>
            <v-card-title>
              <span class="headline">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container grid-list-md>
                <v-layout wrap>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="nroFactura" label="nroFactura"></v-text-field>
                    <v-text-field v-model="diaEmision" label="diaEmision"></v-text-field>
                    <v-text-field v-model="diaPago" label="diaPago"></v-text-field>
                    <v-text-field v-model="moneda" label="moneda"></v-text-field>
                    <v-text-field v-model="totalFacturado" label="totalFacturado"></v-text-field>
                    <v-text-field v-model="retencion" label="retencion"></v-text-field>
                  </v-flex>
                </v-layout>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" flat @click.native="close()">Cancelar</v-btn>
              <v-btn color="blue darken-1" flat @click.native="guardar()">Guardar</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
      <v-data-table :headers="headers" :items="plantas" :search="search" class="elevation-1">
        <template slot="items" slot-scope="props">
          <td class="justify-center layout px-0">
            <v-icon small class="mr-2" @click="editItem(props.item)">edit</v-icon>
          
          </td>
          <td>{{ props.item.id }}</td>
          <td>{{ props.item.nroFactura }}</td>
          <td>{{ props.item.diaEmision }}</td>
          <td>{{ props.item.diaPago }}</td>
          <td>{{ props.item.moneda }}</td>
          <td>{{ props.item.totalFacturado }}</td>
          <td>{{ props.item.retencion }}</td>
          
        </template>
        <template slot="no-data">
          <v-btn color="primary" @click="listar()">Resetear</v-btn>
        </template>
      </v-data-table>
    </v-flex>
  </v-layout>
</template>
<script>

import axios from "axios";
export default {
  data() {
    return {
      plantas: [],
      dialog: false,
      headers: [
        { text: "Opciones", value: "opciones", sortable: false },
        { text: "id", value: "id", sortable: false },
        { text: "NroFactura", value: "nroFactura", sortable: false },
        { text: "DiaEmision", value: "diaEmision", sortable: false },
        { text: "DiaPago", value: "diaPago", sortable: false },
        { text: "Moneda", value: "moneda", sortable: false },
        { text: "TotalFacturado", value: "totalFacturado", sortable: false },
        { text: "Retencion", value: "retencion", sortable: false },
        
      ],
      search: "",
      editedIndex: -1,

      //Model
      id: "",
      nroFactura: "",
      diaEmision: "",
      diaPago: "",
      moneda: "",
      totalFacturado: "",
      retencion: "",
      

      
    };
  },
  computed: {
    formTitle() {
      return this.editedIndex === -1 ? "Nueva Factura" : "Actualizar factura";
    }
  },

  watch: {
    dialog(val) {
      val || this.close();
    }
  },

  created() {
    this.listar();
  },
  methods: {
    listar() {
      let me = this;
      axios
        .get("api/plantas")
        .then(function(response) {
          //console.log(response);
          me.plantas = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },



    
    editItem(item) {
      this.id = item.id;
      this.nroFactura=item.nroFactura;
      this.diaEmision=item.diaEmision;
      this.diaPago=item.diaPago;
      this.moneda=item.moneda;
      this.totalFacturado=item.totalFacturado;
      this.retencion=item.retencion;  

      this.editedIndex = 1;
      this.dialog = true;
    },

  

    close() {
      this.dialog = false;
    },
    limpiar() {
      this.id = "";
      this.nroFactura="";
      this.diaEmision="";
      this.diaPago="";
      this.moneda="";
      this.totalFacturado="";
      this.retencion="";  
      
    },
    guardar() {
      if (this.editedIndex > -1) {
        //Código para editar

        let me = this;
        axios 
          .put("api/plantas", {
            id: me.id,
      nroFactura:me.nroFactura,
      diaEmision:me.diaEmision,
      diaPago:me.diaPago,
      moneda:me.moneda,
      totalFacturado:me.totalFacturado,
      retencion:me.retencion
            
            
          })
          .then(function(response) {
            me.close();
            me.listar();
            me.limpiar();
          })
          .catch(function(error) {
            console.log(error);
          });
      } else {
        //Código para guardar
        let me = this;
        axios
          .post("api/plantas", {
            
    
      nroFactura:me.nroFactura,
      diaEmision:me.diaEmision,
      diaPago:me.diaPago,
      moneda:me.moneda,
      totalFacturado:me.totalFacturado,
      retencion:me.retencion
          })
          .then(function(response) {
            me.close();
            me.listar();
            me.limpiar();
          })
          .catch(function(error) {
            console.log(error);
          });
      }
    }
  }
};
</script>