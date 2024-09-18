<template>
	<div class="addEdit-block" :style='{"minHeight":"100vh","padding":"30px 30px 30px 0","fontSize":"14px","color":"#666","background":"#f4f8fb"}'>
		<el-form
			:style='{"border":"1px solid #e1e8ee","padding":"50px 10% 20px","overflow":"hidden","borderRadius":"0px","alignItems":"flex-start","flexWrap":"wrap","background":"rgba(255,255,255,1)","display":"flex","fontSize":"inherit"}'
			class="add-update-preview"
			ref="ruleForm"
			:model="ruleForm"
			:rules="rules"
			label-width="180px"
		>
			<template >
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-if="type!='info'"  label="课程代码" prop="kechengdaima">
					<el-input v-model="ruleForm.kechengdaima" placeholder="课程代码" clearable  :readonly="ro.kechengdaima"></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else class="input" label="课程代码" prop="kechengdaima">
					<el-input v-model="ruleForm.kechengdaima" placeholder="课程代码" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-if="type!='info'"  label="课程名称" prop="kechengmingcheng">
					<el-input v-model="ruleForm.kechengmingcheng" placeholder="课程名称" clearable  :readonly="ro.kechengmingcheng"></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else class="input" label="课程名称" prop="kechengmingcheng">
					<el-input v-model="ruleForm.kechengmingcheng" placeholder="课程名称" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="upload" v-if="type!='info' && !ro.kechengfengmian" label="课程封面" prop="kechengfengmian">
					<file-upload
						tip="点击上传课程封面"
						action="file/upload"
						:limit="3"
						:multiple="true"
						:fileUrls="ruleForm.kechengfengmian?ruleForm.kechengfengmian:''"
						@change="kechengfengmianUploadChange"
					></file-upload>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="upload" v-else-if="ruleForm.kechengfengmian" label="课程封面" prop="kechengfengmian">
					<img v-if="ruleForm.kechengfengmian.substring(0,4)=='http'" class="upload-img" style="margin-right:20px;" v-bind:key="index" :src="ruleForm.kechengfengmian.split(',')[0]" width="100" height="100">
					<img v-else class="upload-img" style="margin-right:20px;" v-bind:key="index" v-for="(item,index) in ruleForm.kechengfengmian.split(',')" :src="$base.url+item" width="100" height="100">
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-if="type!='info'"  label="课程类型" prop="kechengleixing">
					<el-input v-model="ruleForm.kechengleixing" placeholder="课程类型" clearable  :readonly="ro.kechengleixing"></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else class="input" label="课程类型" prop="kechengleixing">
					<el-input v-model="ruleForm.kechengleixing" placeholder="课程类型" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-if="type!='info'"  label="授课班级" prop="shoukebanji">
					<el-input v-model="ruleForm.shoukebanji" placeholder="授课班级" clearable  :readonly="ro.shoukebanji"></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else class="input" label="授课班级" prop="shoukebanji">
					<el-input v-model="ruleForm.shoukebanji" placeholder="授课班级" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="date" v-if="type!='info'" label="上课时间" prop="shangkeshijian">
					<el-date-picker
						value-format="yyyy-MM-dd HH:mm:ss"
						v-model="ruleForm.shangkeshijian" 
						type="datetime"
						:readonly="ro.shangkeshijian"
                        :picker-options="shangkeshijianPickerOptions"
						placeholder="上课时间"
					></el-date-picker>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-else-if="ruleForm.shangkeshijian" label="上课时间" prop="shangkeshijian">
					<el-input v-model="ruleForm.shangkeshijian" placeholder="上课时间" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="select" v-if="type!='info'" label="工号" prop="gonghao">
					<el-select :disabled="ro.gonghao" @change="gonghaoChange" v-model="ruleForm.gonghao" placeholder="请选择工号">
						<el-option
							v-for="(item,index) in gonghaoOptions"
							v-bind:key="index"
							:label="item"
							:value="item">
						</el-option>
					</el-select>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-else-if="ruleForm.gonghao" label="工号" prop="gonghao">
					<el-input v-model="ruleForm.gonghao" placeholder="工号" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="input" v-if="type!='info'"  label="授课教师" prop="jiaoshixingming">
					<el-input v-model="ruleForm.jiaoshixingming" placeholder="授课教师" clearable  :readonly="ro.jiaoshixingming"></el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else class="input" label="授课教师" prop="jiaoshixingming">
					<el-input v-model="ruleForm.jiaoshixingming" placeholder="授课教师" readonly></el-input>
				</el-form-item>
			</template>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' class="textarea" v-if="type!='info'" label="课程描述" prop="kechengmiaoshu">
					<el-input
					  style="min-width: 200px; max-width: 600px;"
					  type="textarea"
					  :rows="8"
					  placeholder="课程描述"
					  v-model="ruleForm.kechengmiaoshu" >
					</el-input>
				</el-form-item>
				<el-form-item :style='{"border":"0px solid #eee","padding":"0","margin":"0 0 20px 0","color":"inherit","borderRadius":"0px","display":"inline-block","width":"100%","fontSize":"inherit"}' v-else-if="ruleForm.kechengmiaoshu" label="课程描述" prop="kechengmiaoshu">
					<span :style='{"fontSize":"14px","lineHeight":"40px","minWidth":"1000px","color":"inherit","fontWeight":"500","display":"inline-block"}'>{{ruleForm.kechengmiaoshu}}</span>
				</el-form-item>
			<el-form-item :style='{"padding":"10px 0 20px","margin":"30px 0","alignItems":"center","textAlign":"left","display":"block","width":"100%","clear":"both","perspective":"320px","-webkitPerspective":"320px","fontSize":"48px","justifyContent":"flex-start"}' class="btn">
				<el-button class="btn3"  v-if="type!='info'" type="success" @click="onSubmit">
					<span class="icon iconfont icon-tijiao16" :style='{"margin":"0 2px","fontSize":"18px","color":"inherit","display":"none"}'></span>
					保存
				</el-button>
				<el-button class="btn4" v-if="type!='info'" type="success" @click="back()">
					<span class="icon iconfont icon-quxiao09" :style='{"margin":"0 2px","fontSize":"18px","color":"inherit","display":"none"}'></span>
					取消
				</el-button>
				<el-button class="btn5" v-if="type=='info'" type="success" @click="back()">
					<span class="icon iconfont icon-fanhui01" :style='{"margin":"0 2px","fontSize":"18px","color":"inherit","display":"none"}'></span>
					返回
				</el-button>
			</el-form-item>
		</el-form>
    

  </div>
</template>
<script>
export default {
	data() {
		return {
			id: '',
			type: '',
			
			
			ro:{
				kechengdaima : false,
				kechengmingcheng : false,
				kechengfengmian : false,
				kechengleixing : false,
				shoukebanji : false,
				shangkeshijian : false,
				kechengmiaoshu : false,
				gonghao : false,
				jiaoshixingming : false,
			},
			
			
			ruleForm: {
				kechengdaima: '',
				kechengmingcheng: '',
				kechengfengmian: '',
				kechengleixing: '',
				shoukebanji: '',
				shangkeshijian: '',
				kechengmiaoshu: '',
				gonghao: '',
				jiaoshixingming: '',
			},
		
			gonghaoOptions: [],

            shangkeshijianPickerOptions: {
                disabledDate(time) {
                    return time.getTime() < Date.now() - 8.64e7;
                }
            },
			
			rules: {
				kechengdaima: [
					{ required: true, message: '课程代码不能为空', trigger: 'blur' },
				],
				kechengmingcheng: [
					{ required: true, message: '课程名称不能为空', trigger: 'blur' },
				],
				kechengfengmian: [
				],
				kechengleixing: [
				],
				shoukebanji: [
				],
				shangkeshijian: [
				],
				kechengmiaoshu: [
				],
				gonghao: [
				],
				jiaoshixingming: [
				],
			}
		};
	},
	props: ["parent"],
	computed: {



	},
    components: {
    },
	created() {
	},
	methods: {
		
		// 下载
		download(file){
			window.open(`${file}`)
		},
		// 初始化
		init(id,type) {
			if (id) {
				this.id = id;
				this.type = type;
			}
			if(this.type=='info'||this.type=='else'){
				this.info(id);
			}else if(this.type=='logistics'){
				this.logistics=false;
				this.info(id);
			}else if(this.type=='cross'){
				var obj = this.$storage.getObj('crossObj');
				for (var o in obj){
						if(o=='kechengdaima'){
							this.ruleForm.kechengdaima = obj[o];
							this.ro.kechengdaima = true;
							continue;
						}
						if(o=='kechengmingcheng'){
							this.ruleForm.kechengmingcheng = obj[o];
							this.ro.kechengmingcheng = true;
							continue;
						}
						if(o=='kechengfengmian'){
							this.ruleForm.kechengfengmian = obj[o];
							this.ro.kechengfengmian = true;
							continue;
						}
						if(o=='kechengleixing'){
							this.ruleForm.kechengleixing = obj[o];
							this.ro.kechengleixing = true;
							continue;
						}
						if(o=='shoukebanji'){
							this.ruleForm.shoukebanji = obj[o];
							this.ro.shoukebanji = true;
							continue;
						}
						if(o=='shangkeshijian'){
							this.ruleForm.shangkeshijian = obj[o];
							this.ro.shangkeshijian = true;
							continue;
						}
						if(o=='kechengmiaoshu'){
							this.ruleForm.kechengmiaoshu = obj[o];
							this.ro.kechengmiaoshu = true;
							continue;
						}
						if(o=='gonghao'){
							this.ruleForm.gonghao = obj[o];
							this.ro.gonghao = true;
							continue;
						}
						if(o=='jiaoshixingming'){
							this.ruleForm.jiaoshixingming = obj[o];
							this.ro.jiaoshixingming = true;
							continue;
						}
				}
			}
			// 获取用户信息
			this.$http({
				url: `${this.$storage.get('sessionTable')}/session`,
				method: "get"
			}).then(({ data }) => {
				if (data && data.code === 0) {
					var json = data.data;
					if(((json.gonghao!=''&&json.gonghao) || json.gonghao==0) && this.$storage.get("role")!="管理员"){
						this.ruleForm.gonghao = json.gonghao
						this.ro.gonghao = true;
					}
					if(((json.jiaoshixingming!=''&&json.jiaoshixingming) || json.jiaoshixingming==0) && this.$storage.get("role")!="管理员"){
						this.ruleForm.jiaoshixingming = json.jiaoshixingming
						this.ro.jiaoshixingming = true;
					}
				} else {
					this.$message.error(data.msg);
				}
			});
            this.$http({
				url: `option/jiaoshi/gonghao`,
				method: "get"
            }).then(({ data }) => {
				if (data && data.code === 0) {
					this.gonghaoOptions = data.data;
				} else {
					this.$message.error(data.msg);
				}
            });
			
		},
			// 下二随
			gonghaoChange () {
				this.$http({
					url: `follow/jiaoshi/gonghao?columnValue=`+ this.ruleForm.gonghao,
					method: "get"
				}).then(({ data }) => {
					if (data && data.code === 0) {
						if(data.data.jiaoshixingming){
							this.ruleForm.jiaoshixingming = data.data.jiaoshixingming
						}
					} else {
						this.$message.error(data.msg);
					}
				});
			},
    // 多级联动参数

    info(id) {
      this.$http({
        url: `kechengxinxi/info/${id}`,
        method: "get"
      }).then(({ data }) => {
        if (data && data.code === 0) {
        this.ruleForm = data.data;
        //解决前台上传图片后台不显示的问题
        let reg=new RegExp('../../../upload','g')//g代表全部
        } else {
          this.$message.error(data.msg);
        }
      });
    },


    // 提交
    onSubmit() {
	if(this.ruleForm.kechengfengmian!=null) {
		this.ruleForm.kechengfengmian = this.ruleForm.kechengfengmian.replace(new RegExp(this.$base.url,"g"),"");
	}
var objcross = this.$storage.getObj('crossObj');
      //更新跨表属性
       var crossuserid;
       var crossrefid;
       var crossoptnum;
       if(this.type=='cross'){
                var statusColumnName = this.$storage.get('statusColumnName');
                var statusColumnValue = this.$storage.get('statusColumnValue');
                if(statusColumnName!='') {
                        var obj = this.$storage.getObj('crossObj');
                       if(statusColumnName && !statusColumnName.startsWith("[")) {
                               for (var o in obj){
                                 if(o==statusColumnName){
                                   obj[o] = statusColumnValue;
                                 }
                               }
                               var table = this.$storage.get('crossTable');
                             this.$http({
                                 url: `${table}/update`,
                                 method: "post",
                                 data: obj
                               }).then(({ data }) => {});
                       } else {
                               crossuserid=this.$storage.get('userid');
                               crossrefid=obj['id'];
                               crossoptnum=this.$storage.get('statusColumnName');
                               crossoptnum=crossoptnum.replace(/\[/,"").replace(/\]/,"");
                        }
                }
        }
		this.$refs["ruleForm"].validate(valid => {
			if (valid) {
				if(crossrefid && crossuserid) {
					this.ruleForm.crossuserid = crossuserid;
					this.ruleForm.crossrefid = crossrefid;
					let params = { 
						page: 1, 
						limit: 10, 
						crossuserid:this.ruleForm.crossuserid,
						crossrefid:this.ruleForm.crossrefid,
					} 
				this.$http({ 
					url: "kechengxinxi/page", 
					method: "get", 
					params: params 
				}).then(({ 
					data 
				}) => { 
					if (data && data.code === 0) { 
						if(data.data.total>=crossoptnum) {
							this.$message.error(this.$storage.get('tips'));
							return false;
						} else {
							this.$http({
								url: `kechengxinxi/${!this.ruleForm.id ? "save" : "update"}`,
								method: "post",
								data: this.ruleForm
							}).then(({ data }) => {
								if (data && data.code === 0) {
									this.$message({
										message: "操作成功",
										type: "success",
										duration: 1500,
										onClose: () => {
											this.parent.showFlag = true;
											this.parent.addOrUpdateFlag = false;
											this.parent.kechengxinxiCrossAddOrUpdateFlag = false;
											this.parent.search();
											this.parent.contentStyleChange();
										}
									});
								} else {
									this.$message.error(data.msg);
								}
							});

						}
					} else { 
				} 
			});
		} else {
			this.$http({
				url: `kechengxinxi/${!this.ruleForm.id ? "save" : "update"}`,
				method: "post",
			   data: this.ruleForm
			}).then(({ data }) => {
				if (data && data.code === 0) {
					this.$message({
						message: "操作成功",
						type: "success",
						duration: 1500,
						onClose: () => {
							this.parent.showFlag = true;
							this.parent.addOrUpdateFlag = false;
							this.parent.kechengxinxiCrossAddOrUpdateFlag = false;
							this.parent.search();
							this.parent.contentStyleChange();
						}
					});
				} else {
					this.$message.error(data.msg);
			   }
			});
		 }
         }
       });
    },
    // 获取uuid
    getUUID () {
      return new Date().getTime();
    },
    // 返回
    back() {
      this.parent.showFlag = true;
      this.parent.addOrUpdateFlag = false;
      this.parent.kechengxinxiCrossAddOrUpdateFlag = false;
      this.parent.contentStyleChange();
    },
    kechengfengmianUploadChange(fileUrls) {
	    this.ruleForm.kechengfengmian = fileUrls;
    },
  }
};
</script>
<style lang="scss" scoped>
	.amap-wrapper {
		width: 100%;
		height: 500px;
	}
	
	.search-box {
		position: absolute;
	}
	
	.el-date-editor.el-input {
		width: auto;
	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__label {
	  	  padding: 0 10px 0 0;
	  	  color: #333;
	  	  font-weight: 600;
	  	  display: inline-block;
	  	  width: 180px;
	  	  font-size: inherit;
	  	  line-height: 40px;
	  	  text-align: right;
	  	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__content {
	  margin-left: 180px;
	}
	
	.add-update-preview .el-input /deep/ .el-input__inner {
	  	  padding: 0 12px;
	  	  color: inherit;
	  	  font-size: 14px;
	  	  border-color: #e1e8ee;
	  	  border-radius: 0px;
	  	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  	  outline: none;
	  	  background: #f5f8fa;
	  	  width: auto;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  min-width: 350px;
	  	  height: 32px;
	  	}
	.add-update-preview .el-input-number /deep/ .el-input__inner {
		text-align: left;
	  	  padding: 0 12px;
	  	  color: inherit;
	  	  font-size: 14px;
	  	  border-color: #e1e8ee;
	  	  border-radius: 0px;
	  	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  	  outline: none;
	  	  background: #f5f8fa;
	  	  width: auto;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  min-width: 350px;
	  	  height: 32px;
	  	}
	.add-update-preview .el-input-number /deep/ .el-input-number__decrease {
		display: none;
	}
	.add-update-preview .el-input-number /deep/ .el-input-number__increase {
		display: none;
	}
	
	.add-update-preview .el-select /deep/ .el-input__inner {
	  	  padding: 0 10px;
	  	  color: inherit;
	  	  font-size: 14px;
	  	  border-color: #e1e8ee;
	  	  border-radius: 0px;
	  	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  	  outline: none;
	  	  background: #f5f8fa;
	  	  width: auto;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  min-width: 350px;
	  	  height: 32px;
	  	}
	
	.add-update-preview .el-date-editor /deep/ .el-input__inner {
	  	  padding: 0 10px 0 30px;
	  	  color: inherit;
	  	  font-size: 14px;
	  	  border-color: #e1e8ee;
	  	  border-radius: 0px;
	  	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  	  outline: none;
	  	  background: #f5f8fa;
	  	  width: auto;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  min-width: 350px;
	  	  height: 32px;
	  	}
	
	.add-update-preview /deep/ .el-upload--picture-card {
		background: transparent;
		border: 0;
		border-radius: 0;
		width: auto;
		height: auto;
		line-height: initial;
		vertical-align: middle;
	}
	
	.add-update-preview /deep/ .upload .upload-img {
	  	  cursor: pointer;
	  	  color: #c0cfdc;
	  	  object-fit: cover;
	  	  font-size: 24px;
	  	  border-color: #e1e8ee;
	  	  line-height: 90px;
	  	  border-radius: 16px;
	  	  background: #f5f8fa;
	  	  width: 90px;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  text-align: center;
	  	  height: 90px;
	  	}
	
	.add-update-preview /deep/ .el-upload-list .el-upload-list__item {
	  	  cursor: pointer;
	  	  color: #c0cfdc;
	  	  object-fit: cover;
	  	  font-size: 24px;
	  	  border-color: #e1e8ee;
	  	  line-height: 90px;
	  	  border-radius: 16px;
	  	  background: #f5f8fa;
	  	  width: 90px;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  text-align: center;
	  	  height: 90px;
	  	}
	
	.add-update-preview /deep/ .el-upload .el-icon-plus {
	  	  cursor: pointer;
	  	  color: #c0cfdc;
	  	  object-fit: cover;
	  	  font-size: 24px;
	  	  border-color: #e1e8ee;
	  	  line-height: 90px;
	  	  border-radius: 16px;
	  	  background: #f5f8fa;
	  	  width: 90px;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  text-align: center;
	  	  height: 90px;
	  	}
	
	.add-update-preview .el-textarea /deep/ .el-textarea__inner {
	  	  padding: 12px;
	  	  color: inherit;
	  	  font-size: 14px;
	  	  border-color: #e1e8ee;
	  	  min-height: 120px;
	  	  border-radius: 0px;
	  	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  	  outline: none;
	  	  background: #f5f8fa;
	  	  width: auto;
	  	  border-width: 1px;
	  	  border-style: solid;
	  	  min-width: 550px;
	  	  height: auto;
	  	}
	
	.add-update-preview .btn .btn1 {
				border: 1px solid rgba(53, 184, 224, 0.1);
				cursor: pointer;
				padding: 0 10px;
				margin: 0px 4px;
				color: #fff;
				display: inline-block;
				font-size: 12px;
				line-height: 24px;
				border-radius: 2px;
				outline: none;
				background: #03a9f4;
				width: auto;
				height: 26px;
			}
	
	.add-update-preview .btn .btn1:hover {
				box-shadow: 0px 0px 9px #ccc;
				transform: translate3d(0px, 0px, 0px);
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn2 {
				border: 1px solid rgba(24, 138, 226, 0.1) ;
				cursor: pointer;
				border-radius: 2px;
				padding: 0 10px;
				margin: 0px 4px;
				outline: none;
				color: #fff;
				background: #6c757d;
				width: auto;
				font-size: 12px;
				line-height: 24px;
				height: 26px;
			}
	
	.add-update-preview .btn .btn2:hover {
				box-shadow: 0px 0px 9px #ccc;
				transform: translate3d(0px, 0px, 0px);
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn3 {
				border: 0px solid #0260ad;
				cursor: pointer;
				border-radius: 2px;
				padding: 0 20px;
				margin: 0px 4px;
				outline: none;
				color: #fff;
				background: #78bcee;
				width: auto;
				font-size: 12px;
				line-height: 24px;
				height: 26px;
			}
	
	.add-update-preview .btn .btn3:hover {
				box-shadow: 0px 0px 9px #ccc;
				transform: translate3d(0px, 0px, 0px);
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn4 {
				border: 0px solid rgba(126, 96, 16, .2);
				cursor: pointer;
				border-radius: 2px;
				padding: 0 20px;
				margin: 0px 4px;
				outline: none;
				color: #fff;
				background: #7dc855;
				width: auto;
				font-size: 12px;
				line-height: 24px;
				height: 26px;
			}
	
	.add-update-preview .btn .btn4:hover {
				box-shadow: 0px 0px 9px #ccc;
				transform: translate3d(0px, 0px, 0px);
				background: rgba(28,132,198,1);
				opacity: 1;
			}
	
	.add-update-preview .btn .btn5 {
				border: 0px solid rgba(114, 123, 132, 0.1);
				cursor: pointer;
				border-radius: 2px;
				padding: 0 20px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: #fcce54;
				width: auto;
				font-size: 12px;
				line-height: 24px;
				height: 26px;
			}
	
	.add-update-preview .btn .btn5:hover {
				box-shadow: 0px 0px 9px #ccc;
				transform: translate3d(0px, 0px, 0px);
				opacity: 1;
			}
</style>
