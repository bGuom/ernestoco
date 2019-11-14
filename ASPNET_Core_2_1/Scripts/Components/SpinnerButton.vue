<template>
  <button class="btn btn-primary block full-width m-b" :class="getBackgroundClass" type="button">
    <div style="display: inline-flex">
      <transition name="fade" mode="out-in">
        <div :class="getSpinnerClass"></div>
      </transition>
    </div>

    <div style="display: inline">
      <slot v-if="showSlot"></slot>
    </div>
  </button>
</template>

<script>
export default {
  name: "vue-button-spinner",
  props: {
    isLoading: {
      type: Boolean,
      default: false
    },
    status: {
      type: String | Boolean,
      default: ""
    },
    spinnerClass: {
      type: String,
      default: ""
    },
  },
  computed: {
    getSpinnerClass() {
      return {
        spinner: this.loading,
        check: !this.emptyStatus && this.isSuccess && !this.loading,
        cross: !this.emptyStatus && !this.isSuccess && !this.loading
      };
    },
    getBackgroundClass() {
      return {
        "btn btn-error lock full-width m-b": !this.emptyStatus && !this.isSuccess,
        "btn btn-success block full-width m-b": this.isSuccess,
        "is-loading": this.loading,
        [this.spinnerClass]: true
      };
    },
    loading() {
      return this.isLoading;
    },
    isSuccess() {
      return this.status === "success" || this.status === true;
    },
    emptyStatus() {
      return this.status === "";
    },
    showSlot() {
      return this.loading || (!this.loading && this.emptyStatus);
    }
  }
};
</script>

<style lang="css" scoped>
.fade-enter-active,
.fade-leave-active {
  transition: opacity 1s;
}

.fade-enter,
.fade-leave-active {
  opacity: 0;
  will-change: opacity;
}

@keyframes rotation {
  from {
    transform: rotate(0deg);
  }

  to {
    transform: rotate(359deg);
  }
}

button.vue-btn-loader-error:not(.is-loading) {
  /*width: 48px;*/
  background-color: #f44336;
  color: #fff;
}

button.vue-btn-loader-success:not(.is-loading) {
  /*width: 48px;*/
  background-color: #8bc34a;
  color: #fff;
}

button.vue-btn:disabled {
  cursor: not-allowed;
}

.spinner {
  height: 5px;
  width: 5px;
  margin-right: 8px;
  opacity: 1;
  filter: alpha(opacity=100);
  animation: rotation 0.7s infinite linear;
  /*border: 4px solid rgba(0, 0, 0, 0.2);*/
  border-top-color: #9e9e9e;
  border-radius: 100%;
  transition: 0.3s all ease;
  padding: 7px !important;
  min-width: 1rem !important;
  min-height: 1rem !important;
}
/**
          Check Icon
      **/
.check {
  display: inline-block;
  width: 23px;
  height: 20px;
  border-radius: 50%;
  transform: rotate(45deg);
  color: white;
  will-change: transform;
  margin-top: 5px;
}

.check:before {
  content: "";
  position: absolute;
  width: 3px;
  height: 9px;
  background-color: #fff;
  left: 11px;
  top: 6px;
}

.check:after {
  content: "";
  position: absolute;
  width: 3px;
  height: 3px;
  background-color: #fff;
  left: 8px;
  top: 12px;
}
/**
          Cross Icon
      **/
.cross {
  display: inline-block;
  width: 17px;
  height: 16px;
  position: relative;
  margin-top: 10px;
}

.cross:before,
.cross:after {
  position: absolute;
  left: 8px;
  content: " ";
  height: 16px;
  width: 2px;
  background-color: #fff;
}

.cross:before {
  transform: rotate(45deg);
  will-change: transform;
}

.cross:after {
  transform: rotate(-45deg);
  will-change: transform;
}
</style>